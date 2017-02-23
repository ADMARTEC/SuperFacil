using System.ComponentModel.DataAnnotations;

namespace SuperFacil.Infraestructure.CrossCutting.Model
{
    public class SetPassword
    {
        [Required]
        [StringLength(100,MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar a nova password")]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }
}
