using System.ComponentModel.DataAnnotations;

namespace SuperFacil.Infraestructure.CrossCutting.Model
{
    public class VerifyPhoneNumber
    {
        [Required]
        [Display(Name = "Codigo")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Telefone")]
        public string PhoneNumber { get; set; }
    }
}
