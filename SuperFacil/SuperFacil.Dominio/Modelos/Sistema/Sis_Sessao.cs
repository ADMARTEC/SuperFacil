using SuperFacil.Dominio.Modelos.Administracao;
using System;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    public class Sis_Sessao
    {
        #region - Propriedade -
        public int Sessao_ID { get; set; }
        public int Empresa_ID { get; set; }
        public string Dispositivo { get; set; }
        public string Coordenadas { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Fim { get; set; }
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
