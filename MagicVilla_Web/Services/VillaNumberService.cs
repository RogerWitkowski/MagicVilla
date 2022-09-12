using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;

namespace MagicVilla_Web.Services
{
    public class VillaNumberService : BaseService, IVillaNumberService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _villaUrl;

        public VillaNumberService(IHttpClientFactory httpClientFactory, IConfiguration configuration) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _villaUrl = configuration.GetValue<string>("ServicesUrls:VillaAPI");
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = _villaUrl + "api/villaNumberAPI"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = _villaUrl + "api/villaNumberAPI/" + id
            });
        }

        public Task<T> CreateAsync<T>(CreateVillaNumberDTO createNumberDTO)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = createNumberDTO,
                Url = _villaUrl + "api/villaNumberAPI"
            });
        }

        public Task<T> UpdateAsync<T>(UpdateVillaNumberDTO updateNumberDTO)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.PUT,
                Data = updateNumberDTO,
                Url = _villaUrl + "api/villaNumberAPI/" + updateNumberDTO.VillaNo
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.DELETE,
                Url = _villaUrl + "api/villaNumberAPI/" + id
            });
        }
    }
}