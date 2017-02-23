using SuperFacil.Domain.Entities.Sistema.Generico;
using System;
using System.Collections.Generic;

namespace SuperFacil.Domain.Entities.Inquerito
{
    public class Inq_Questionario
    {
        public int Questionario_ID { get; set; }
        public int Inquerito_ID { get; set; }
        public int Pais_ID { get; set; }
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
        public virtual Inq_Inquerito Inquerito { get; set; }
        public virtual Sis_Gen_Pais Pais { get; set; }
        public virtual ICollection<Inq_Questionario_Resposta> Questionario_Resposta { get; set; }
        #endregion
    }
}
