using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Kullaınıcı adını giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifreyi adını giriniz")]
        public string Password { get; set; }
    }
}
