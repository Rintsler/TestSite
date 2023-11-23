using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TestSite.Models
{
    public class UserAcc : IdentityUser
    {
        [Display(Name = "Название компании")]
        public bool BTCJob { get; set; }
        [Display(Name = "Название компании")]
        public string sferaD { get; set; }
        [Display(Name = "Название компании")]
        public string fondInv { get; set; }
    }
}