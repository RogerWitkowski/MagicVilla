using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;

namespace MagicVilla_Web.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _villaUrl;

        public VillaService(IHttpClientFactory httpClientFactory, IConfiguration configuration) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _villaUrl = configuration.GetValue<string>("ServicesUrls:VillaAPI");
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = _villaUrl + "api/v1/VillaAPI",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = _villaUrl + "api/v1/VillaAPI/" + id,
                Token = token
            });
        }

        public Task<T> CreateAsync<T>(CreateVillaDTO createDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = createDTO,
                Url = _villaUrl + "api/v1/VillaAPI",
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(UpdateVillaDTO updateDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.PUT,
                Data = updateDTO,
                Url = _villaUrl + "api/v1/VillaAPI/" + updateDTO.Id,
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.DELETE,
                Url = _villaUrl + "api/v1/VillaAPI/" + id,
                Token = token
            });
        }
    }
}