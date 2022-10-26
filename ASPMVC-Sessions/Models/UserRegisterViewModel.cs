using System.ComponentModel.DataAnnotations;

namespace ASPMVC_Sessions.Models
{
    public class UserRegisterViewModel
    {
        [Display(Name = "Nom d'utilisateur")]
        [Required(ErrorMessage = "Le Champ est requis.")]
        public string UserName { get; set; }

        [Display(Name = "Adresse Email")]
        [Required(ErrorMessage = "Le Champ est requis.")]
        [EmailAddress(ErrorMessage = "Adresse Email Invalide")]
        public string Email { get; set; }

        [Display(Name = "Mot de passe")]
        [Required(ErrorMessage = "Le Champ est requis.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Les deux mot de passe doivent correspondre")]
        [Display(Name = "Confirmation de mot de passe")]
        [Required(ErrorMessage = "Le Champ est requis.")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }
    }
}
