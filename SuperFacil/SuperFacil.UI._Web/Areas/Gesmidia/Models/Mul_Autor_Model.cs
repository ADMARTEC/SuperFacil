using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperFacil.UI._Web.Areas.Gesmidia.Models
{
    public class Mul_Autor_Model
    {
        #region - Propriedade -       
        public int Autor_ID { get; set; }
        [Display(Name = "Empresa")]
        public int Empresa_ID { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Observação")]
        public string Nota { get; set; }
        [Display(Name = "Activo?")]
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Default { get; set; } = false;
        #endregion

        #region - Listagem -
        
        #endregion
    }
}