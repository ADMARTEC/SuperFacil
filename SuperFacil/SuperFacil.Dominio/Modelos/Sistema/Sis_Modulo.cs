using System;
using System.Collections.Generic;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    public class Sis_Modulo
    {
        #region - Construtor -
        public Sis_Modulo()
        {
            this.Menu = new List<Sis_Menu>();
        }
        #endregion

        #region - Propriedade -
        public int Modulo_ID { get; set; }
        public int Aplicacao_ID { get; set; }
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
        public virtual ICollection<Sis_Menu> Menu { get; set; }
        public virtual Sis_Aplicacao Aplicacao { get; set; }
        #endregion
    }
}
