using System.ComponentModel.DataAnnotations;

namespace SuperFacil.Infraestructure.CrossCutting.Model
{
    public class Register
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(100, MinimumLength =6)]    
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirmar Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
