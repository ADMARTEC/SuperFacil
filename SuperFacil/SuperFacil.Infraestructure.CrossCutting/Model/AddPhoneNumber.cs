using System.ComponentModel.DataAnnotations;

namespace SuperFacil.Infraestructure.CrossCutting.Model
{
    public class AddPhoneNumber
    {
        [Phone]
        [Required]
        [Display(Name ="Numero de Telefone")]
        public string Number { get; set; }
    }
}
