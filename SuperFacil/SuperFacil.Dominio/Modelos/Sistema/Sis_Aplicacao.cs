using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Collections.Generic;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    public class Sis_Aplicacao
    {
        #region - Construtor -
        public Sis_Aplicacao()
        {
            this.Modulo = new List<Sis_Modulo>();
            this.Pefil = new List<Adm_Perfil>();
        }
        #endregion

        #region - Propriedade -        
        public int Aplicacao_ID { get; set; }
        public string Designacao { get; set; }
        public string Versao { get; set; }
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Default { get; set; } = false;
        #endregion

        #region - Relacionamento -
        public virtual ICollection<Sis_Modulo> Modulo { get; set; }
        public virtual ICollection<Adm_Perfil> Pefil { get; set; }
        #endregion
    }
}
