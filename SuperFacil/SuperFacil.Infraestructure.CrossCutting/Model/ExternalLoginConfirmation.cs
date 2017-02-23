using System.ComponentModel.DataAnnotations;

namespace SuperFacil.Infraestructure.CrossCutting.Model
{
    public class ExternalLoginConfirmation
    {
        [Required]
        [Display(Name ="Email")]
        public string Email { get; set; }
    }
}
