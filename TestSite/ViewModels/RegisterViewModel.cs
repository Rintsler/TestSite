using System.ComponentModel.DataAnnotations;

namespace TestSite.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Название компании")]
        public string CompName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Сфера деятельности")]
        public string sferaD { get; set; }

        [Display(Name = "Работа с биткоином")]
        public bool BTCJob { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Инвистиционный фонд")]
        public string fondInv { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}