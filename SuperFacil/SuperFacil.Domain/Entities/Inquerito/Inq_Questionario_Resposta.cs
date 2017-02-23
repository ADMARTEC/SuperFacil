using System;

namespace SuperFacil.Domain.Entities.Inquerito
{
    public class Inq_Questionario_Resposta
    {
        public int Questionario_Resposta_ID { get; set; }
        public int Questionario_ID { get; set; }
        public int Inquerito_Pergunta_ID { get; set; }
        public int Inquerito_Resposta_ID { get; set; }
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
        public virtual Inq_Questionario Questionario { get; set; }
        public virtual Inq_Inquerito_Pergunta Inquerito_Pergunta { get; set; }
        public virtual Inq_Inquerito_Resposta Inquerito_Resposta { get; set; }
        #endregion
    }
}

