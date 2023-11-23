using System.ComponentModel.DataAnnotations;

namespace TestSite.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Имя компании")]
        public string CompName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}