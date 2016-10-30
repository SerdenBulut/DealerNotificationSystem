using System.ComponentModel.DataAnnotations;

namespace DNS.Web.Models
{
    public sealed class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Kullanıcı adı zorunlu alandır.")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Şifre zorunlu alandır.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}