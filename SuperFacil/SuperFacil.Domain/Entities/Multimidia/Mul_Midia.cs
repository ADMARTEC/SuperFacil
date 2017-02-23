using System;

namespace SuperFacil.Domain.Entities.Multimidia
{
    public class Mul_Midia
    {
        #region - Proprieties -
        public int Midia_ID { get; set; }
        public int Autor_ID { get; set; }
        public int Localizacao_ID { get; set; }
        public string Designacao { get; set; }  
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Default { get; set; } = false;   
        #endregion

        #region - Relations -
        public virtual Mul_Autor Autor { get; set; }
        public virtual Mul_Localizacao Localizacao { get; set; }
        #endregion
    }

}
