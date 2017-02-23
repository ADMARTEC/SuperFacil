using System;
using System.Collections.Generic;

namespace SuperFacil.Presentation._Web.Areas.Inquerito.ViewModel
{
    public class Inq_Inquerito_Resposta_ViewModel
    {
        #region - Propriedade -
        public int Inquerito_Resposta_ID { get; set; }
        public int Inquerito_Pergunta_ID { get; set; }
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
        #endregion

        #region - Relacionamento -
        public virtual Inq_Inquerito_Pergunta_ViewModel Inquerito_Pergunta { get; set; }
        public virtual ICollection<Inq_Questionario_Resposta_ViewModel> Questionario_Resposta { get; set; }
        #endregion
    }
}
