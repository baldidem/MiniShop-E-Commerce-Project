using System.ComponentModel.DataAnnotations;

namespace MiniShop.Web.Models
{
    public class PasswordModel
    {
        public string UserId { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu.")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")]
        public string RePassword { get; set; }
    }
}
