using System.ComponentModel.DataAnnotations;

namespace ASPMVC_Sessions.Models
{
    public class UserLoginViewModel
    {

        [Display(Name = "Adresse email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Display(Name = "Mot de passe")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
