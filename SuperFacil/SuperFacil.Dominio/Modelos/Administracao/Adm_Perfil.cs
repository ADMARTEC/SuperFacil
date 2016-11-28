using SuperFacil.Dominio.Modelos.Sistema;
using System;

namespace SuperFacil.Dominio.Modelos.Administracao
{
    public class Adm_Perfil
    {
        #region - Construtor -
        public Adm_Perfil()
        {
            // this.Usuario = new List<Adm_Usuario>();
        }
        #endregion

        #region - Propriedade -
        public int Perfil_ID { get; set; }
        public int Aplicacao_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int? Parent_ID { get; set; }
        public string Designacao { get; set; }
        public int? HorarioAcesso_ID { get; set; }
        public bool Activo { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; }
        public bool Default { get; set; } = false;
        #endregion

        #region - Relacionamento -
        //  public virtual ICollection<Adm_Usuario> Usuario { get; set; }
        public virtual Adm_Empresa Empresa { get; set; }
        public virtual Sis_HorarioAcesso HorarioAcesso { get; set; }
        public virtual Sis_Aplicacao Aplicacao { get; set; }
        #endregion
                
    }
}
