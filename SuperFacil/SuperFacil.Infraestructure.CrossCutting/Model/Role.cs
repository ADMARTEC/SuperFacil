using System.ComponentModel.DataAnnotations;

namespace SuperFacil.Infraestructure.CrossCutting.Model
{
    public class Role
    {
        public int Role_ID { get; set; }
        [Required(AllowEmptyStrings =false)]
        [Display(Name="Nome da Role")]
        public string Name { get; set; }
    }
}
