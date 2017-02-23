using SuperFacil.Domain.Entities.Inquerito;
using System;
using System.Collections.Generic;

namespace SuperFacil.Presentation._Web.ViewModels.Sistema
{
    public class Sis_Empresa_ViewModel
    {
        public int Empresa_ID { get; set; }
        public int? Parent_ID { get; set; }
        public string Designacao { get; set; }
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool DefaultSystem { get; set; } = false;


        #region - Relacionamento -
        public virtual ICollection<Inq_Inquerito> Inquerito { get; set; }
        #endregion
    }
}
