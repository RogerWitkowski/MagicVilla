namespace MagicVilla_Web.Models.Dto
{
    public class LoginResponseDTO
    {
        public UserWebDTO User { get; set; }
        public string Token { get; set; }
    }
}