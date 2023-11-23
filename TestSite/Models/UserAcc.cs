using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TestSite.Models
{
    public class UserAcc : IdentityUser
    {
        [Display(Name = "Работа с биткоином")]
        public bool BTCJob { get; set; }
        [Display(Name = "Сфера деятельности")]
        public string sferaD { get; set; }
        [Display(Name = "Инвистиционный фонд")]
        public string fondInv { get; set; }
    }
}