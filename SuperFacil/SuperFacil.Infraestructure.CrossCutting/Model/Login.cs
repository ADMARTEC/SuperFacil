using System.ComponentModel.DataAnnotations;

namespace SuperFacil.Infraestructure.CrossCutting.Model
{
    public class Login
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Lembrar-me")]
        public string RememberMe { get; set; }
    }
}
