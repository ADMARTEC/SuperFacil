using System;
using System.Collections.Generic;

namespace SuperFacil.Domain.Entities.Multimidia
{
    public class Mul_Localizacao
    {   

        #region - Prorieties -
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
        public virtual ICollection<Mul_Midia> Midia { get; set; }
        #endregion
    }
}
