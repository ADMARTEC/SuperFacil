using System;
using System.Collections.Generic;


namespace SuperFacil.Presentation._Web.Areas.Inquerito.ViewModel
{
    public class Inq_Inquerito_Pergunta_Categoria_ViewModel
    {
        public int Inquerito_Pergunta_Categoria_ID { get; set; }
        public int Inquerito_ID { get; set; }
        public string Designacao { get; set; }
        public string Observacao { get; set; }
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
        public virtual Inq_Inquerito_ViewModel Inquerito { get; set; }
        public virtual ICollection<Inq_Inquerito_Pergunta_ViewModel> Inquerito_Pergunta { get; set; }
        #endregion

    }
}
