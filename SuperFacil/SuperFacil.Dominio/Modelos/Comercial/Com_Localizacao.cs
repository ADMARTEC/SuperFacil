using SuperFacil.Dominio.Modelos.Administracao;
using System;

namespace SuperFacil.Dominio.Modelos.Comercial
{
    public class Com_Localizacao
    {
        #region - Propriedade -
        public int Localizacao_ID { get; set; }
        public int Empresa_ID { get; set; }
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
        public virtual Adm_Empresa Empresa { get; set; }
        #endregion
    }
}
