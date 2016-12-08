using System;

namespace SuperFacil.Dominio.Modelos.Global
{
    public class Glo_Pais 
    {
        #region - Propriedade -
        public int Pais_ID { get; set; }
        public int? Parent_ID { get; set; }
        public string Designacao { get; set; }
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Default { get; set; } = false;
        #endregion

        #region - Relacionamento -
        public virtual Glo_Morada Morada { get; set; }
        #endregion                
    }
}
