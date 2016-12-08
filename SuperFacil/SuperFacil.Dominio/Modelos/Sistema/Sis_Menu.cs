using System;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    public class Sis_Menu 
    {
        #region - Propriedade -
        public int Menu_ID { get; set; }
        public int Modulo_ID { get; set; }
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
        public virtual Sis_Modulo Modulo { get; set; }
        #endregion        
    }
}
