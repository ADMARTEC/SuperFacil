using System.ComponentModel.DataAnnotations;

namespace SuperFacil.Infraestructure.CrossCutting.Model
{
    public class Forgot
    {
        [Required]
        [Display(Name ="Email")]
        public string Email { get; set; }
    }
}
