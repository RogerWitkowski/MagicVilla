using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;

namespace MagicVilla_Web.Services
{
    public class AuthService : BaseService, IAuthService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _villaUrl;

        public AuthService(IHttpClientFactory httpClientFactory, IConfiguration configuration) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _villaUrl = configuration.GetValue<string>("ServicesUrls:VillaAPI");
        }

        public Task<T> LoginAsync<T>(LoginRequestDTO loginRequestDTO)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = loginRequestDTO,
                Url = _villaUrl + "api/v1/UserAuth/login"
            });
        }

        public Task<T> RegisterAsync<T>(RegistrationRequestDTO createUser)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = createUser,
                Url = _villaUrl + "api/v1/UserAuth/register"
            });
        }
    }
}