using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace MagicVilla_VillaAPI.Controllers.v1
{
    [Route("api/v{version:apiVersion}/VillaAPI")]
    [ApiController]
    [ApiVersion("1.0")]
    public class VillaAPIController : ControllerBase
    {
        protected APIResponse _apiResponse;
        private readonly IVillaRepository _dbVillaRepository;
        private readonly IMapper _mapper;

        public VillaAPIController(IVillaRepository dbVillaRepository, IMapper mapper)
        {
            _dbVillaRepository = dbVillaRepository;
            _mapper = mapper;
            this._apiResponse = new();
        }

        [HttpGet]
        [ResponseCache(Duration = 30)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<APIResponse>> GetVillas([FromQuery(Name = "filterOccupancy")] int? occupancy)
        {
            try
            {
                IEnumerable<Villa> villaList;

                if (occupancy > 0)
                {
                    villaList = await _dbVillaRepository.GetAllAsync(u => u.Occupancy == occupancy);
                }
                else
                {
                    villaList = await _dbVillaRepository.GetAllAsync();
                }

                _apiResponse.Result = _mapper.Map<List<VillaDTO>>(villaList);
                _apiResponse.StatusCode = HttpStatusCode.OK;
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

        [HttpGet("{id:int}", Name = "GetVilla")]
        [Authorize(Roles = "admin")]
        [ResponseCache(CacheProfileName = "Default30s")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVilla(int id)
        {
            try
            {
                if (id == 0)
                {
                    //_logger.Log("GetAsync Villa Error with Id:" + id, "error");
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_apiResponse);
                }

                var villa = await _dbVillaRepository.GetAsync(v => v.Id == id);

                if (villa == null)
                {
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_apiResponse);
                }

                _apiResponse.Result = _mapper.Map<VillaDTO>(villa);
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
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<APIResponse>> CreateVilla([FromBody] CreateVillaDTO createViDTO)
        {
            try
            {
                if (await _dbVillaRepository.GetAsync(u => u.Name.ToLower() == createViDTO.Name.ToLower()) != null)
                {
                    ModelState.AddModelError("ErrorMessages", "Villa already exists!");
                    return BadRequest(ModelState);
                }

                if (createViDTO == null)
                {
                    return BadRequest(createViDTO);
                }
                Villa villa = _mapper.Map<Villa>(createViDTO);

                await _dbVillaRepository.CreateAsync(villa);
                _apiResponse.Result = _mapper.Map<VillaDTO>(villa);
                _apiResponse.IsSuccess = true;
                _apiResponse.StatusCode = HttpStatusCode.Created;

                return CreatedAtRoute("GetVilla", new { id = villa.Id }, _apiResponse);
            }
            catch (Exception exeption)
            {
                _apiResponse.IsSuccess = false;
                _apiResponse.ErrorMessages = new List<string>() { exeption.ToString() };
            }

            return _apiResponse;
        }

        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<APIResponse>> DeleteVilla(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var villa = await _dbVillaRepository.GetAsync(u => u.Id == id);
                if (villa == null)
                {
                    return NotFound();
                }

                await _dbVillaRepository.RemoveAsync(villa);

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

        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<APIResponse>> UpdateVilla(int id, [FromBody] UpdateVillaDTO updateViDTO)
        {
            try
            {
                if (updateViDTO == null || id != updateViDTO.Id)
                {
                    return BadRequest();
                }

                Villa model = _mapper.Map<Villa>(updateViDTO);

                await _dbVillaRepository.UpdateAsync(model);
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

        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<UpdateVillaDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
                return BadRequest();
            }
            var villa = await _dbVillaRepository.GetAsync(u => u.Id == id, tracked: false);

            UpdateVillaDTO villaDTO = _mapper.Map<UpdateVillaDTO>(villa);

            if (villa == null)
            {
                return BadRequest();
            }
            patchDTO.ApplyTo(villaDTO, ModelState);

            Villa model = _mapper.Map<Villa>(villaDTO);

            //Villa model = new Villa()
            //{
            //    Amenity = villaDTO.Amenity,
            //    Details = villaDTO.Details,
            //    Id = villaDTO.Id,
            //    ImageUrl = villaDTO.ImageUrl,
            //    Name = villaDTO.Name,
            //    Occupancy = villaDTO.Occupancy,
            //    Rate = villaDTO.Rate,
            //    Sqft = villaDTO.Sqft,
            //};

            await _dbVillaRepository.UpdateAsync(model);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }
    }
}