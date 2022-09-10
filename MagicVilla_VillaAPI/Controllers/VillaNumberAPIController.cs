using System.Collections.Immutable;
using System.Net;
using System.Reflection.PortableExecutable;
using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/villaNumberAPI")]
    [ApiController]
    public class VillaNumberAPIController : ControllerBase
    {
        protected APIResponse _apiResponse;

        private readonly IVillaNumberRepository _dbVillaNumber;
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;

        public VillaNumberAPIController(IVillaNumberRepository dbVillaNumber, IMapper mapper, IVillaRepository dbVilla)
        {
            _dbVillaNumber = dbVillaNumber;
            _mapper = mapper;
            this._apiResponse = new();
            _dbVilla = dbVilla;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetVillasNumber()
        {
            try
            {
                IEnumerable<VillaNumber> villaNumberList = await _dbVillaNumber.GetAllAsync();
                _apiResponse.Result = _mapper.Map<List<VillaNumberDTO>>(villaNumberList);
                _apiResponse.StatusCode = HttpStatusCode.OK;
                _apiResponse.IsSuccess = true;
                return Ok(_apiResponse);
            }
            catch (Exception exception)
            {
                _apiResponse.IsSuccess = false;
                _apiResponse.ErrorMessages = new List<string>() { exception.ToString() };
            }
            return _apiResponse;
        }

        [HttpGet("{vNumber:int}", Name = "GetVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVillaNumber(int vNumber)
        {
            try
            {
                if (vNumber == 0)
                {
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_apiResponse);
                }

                var villaNumber = await _dbVillaNumber.GetAsync(vn => vn.VillaNo == vNumber);

                if (villaNumber == null)
                {
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_apiResponse);
                }

                _apiResponse.Result = _mapper.Map<VillaNumberDTO>(villaNumber);
                _apiResponse.IsSuccess = true;
                _apiResponse.StatusCode = HttpStatusCode.OK;
                return Ok(_apiResponse);
            }
            catch (Exception exeption)
            {
                _apiResponse.IsSuccess = false;
                _apiResponse.ErrorMessages = new List<string>() { exeption.ToString() };
            }

            return _apiResponse;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateVillaNumber(
            [FromBody] CreateVillaNumberDTO createVillaNumberDto)
        {
            try
            {
                if (await _dbVillaNumber.GetAsync(v => v.VillaNo == createVillaNumberDto.VillaNo) != null)
                {
                    ModelState.AddModelError("CustomError", "Villa number already exists!");
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(ModelState);
                }

                if (await _dbVilla.GetAsync(v => v.Id == createVillaNumberDto.VillaId) == null)
                {
                    ModelState.AddModelError("CustomError", "Villa ID is invalid");
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_apiResponse);
                }

                if (createVillaNumberDto == null)
                {
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    _apiResponse.IsSuccess = false;
                    return BadRequest(createVillaNumberDto);
                }

                VillaNumber villaNumber = _mapper.Map<VillaNumber>(createVillaNumberDto);

                await _dbVillaNumber.CreateAsync(villaNumber);
                _apiResponse.Result = _mapper.Map<VillaNumberDTO>(villaNumber);
                _apiResponse.IsSuccess = true;
                _apiResponse.StatusCode = HttpStatusCode.Created;

                return Ok(_apiResponse);
            }
            catch (Exception exeption)
            {
                _apiResponse.IsSuccess = false;
                _apiResponse.ErrorMessages = new List<string>() { exeption.ToString() };
            }

            return _apiResponse;
        }

        [HttpDelete("{villaNum:int}", Name = "DeleteVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> DeleteVillaNumber(int villaNum)
        {
            try
            {
                if (villaNum == 0)
                {
                    _apiResponse.IsSuccess = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_apiResponse);
                }

                var villaNumber = await _dbVillaNumber.GetAsync(vn => vn.VillaNo == villaNum);
                if (villaNumber == null)
                {
                    _apiResponse.IsSuccess = false;
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_apiResponse);
                }

                await _dbVillaNumber.RemoveAsync(villaNumber);

                _apiResponse.StatusCode = HttpStatusCode.NoContent;
                _apiResponse.IsSuccess = true;
                return Ok(_apiResponse);
            }
            catch (Exception exeption)
            {
                _apiResponse.IsSuccess = false;
                _apiResponse.ErrorMessages = new List<string>() { exeption.ToString() };
            }

            return _apiResponse;
        }

        [HttpPut("{villaNum:int}", Name = "UpdateVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateVillaNumber(int villaNum,
            [FromBody] UpdateVillaNumberDTO updateVillaNumberDto)
        {
            try
            {
                if (updateVillaNumberDto == null || villaNum != updateVillaNumberDto.VillaNo)
                {
                    _apiResponse.IsSuccess = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_apiResponse);
                }

                if (await _dbVilla.GetAsync(v => v.Id == updateVillaNumberDto.VillaId) == null)
                {
                    ModelState.AddModelError("CustomError", "Villa ID is invalid");
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(ModelState);
                }

                VillaNumber villaNumber = _mapper.Map<VillaNumber>(updateVillaNumberDto);

                await _dbVillaNumber.UpdateAsync(villaNumber);
                _apiResponse.StatusCode = HttpStatusCode.NoContent;
                _apiResponse.IsSuccess = true;
                return Ok(_apiResponse);
            }
            catch (Exception exeption)
            {
                _apiResponse.IsSuccess = false;
                _apiResponse.ErrorMessages = new List<string>() { exeption.ToString() };
            }

            return _apiResponse;
        }

        [HttpPatch("{villaNum:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVillaNumber(int villaNum,
            JsonPatchDocument<UpdateVillaNumberDTO> patchVillaNumberDto)
        {
            if (patchVillaNumberDto == null || villaNum == 0)
            {
                //_apiResponse.IsSuccess = false;
                //_apiResponse.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest(_apiResponse);
            }

            var villaNumber = await _dbVillaNumber.GetAsync(vn => vn.VillaNo == villaNum, tracked: false);

            UpdateVillaNumberDTO villaNumberDto = _mapper.Map<UpdateVillaNumberDTO>(villaNumber);

            if (villaNumber == null)
            {
                //_apiResponse.IsSuccess = false;
                //_apiResponse.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest();
            }
            patchVillaNumberDto.ApplyTo(villaNumberDto, ModelState);

            VillaNumber villaNbr = _mapper.Map<VillaNumber>(villaNumberDto);

            await _dbVillaNumber.UpdateAsync(villaNbr);

            if (!ModelState.IsValid)
            {
                //_apiResponse.IsSuccess = false;
                //_apiResponse.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest();
            }

            return NoContent();
        }
    }
}