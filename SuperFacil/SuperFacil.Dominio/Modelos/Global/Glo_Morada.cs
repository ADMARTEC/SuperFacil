using System;
using System.Collections.Generic;

namespace SuperFacil.Dominio.Modelos.Global
{
    public class Glo_Morada 
    {
        #region - Construtor -      
        public Glo_Morada()
        {  
            this.Pais = new List<Glo_Pais>();
        }
        #endregion

        #region - Propriedade -
        public int Morada_ID { get; set; }
        public int Pais_ID { get; set; }
        public string Designacao { get; set; }
        public bool Master { get; set; } = false;
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Default { get; set; } = false;
        #endregion

        #region - Relacionamento - 
        public virtual ICollection<Glo_Pais> Pais { get; set; }
        #endregion

        
    }
}
