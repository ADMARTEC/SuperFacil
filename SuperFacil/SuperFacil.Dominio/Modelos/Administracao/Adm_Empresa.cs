using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Dominio.Modelos.Sistema;
using System;
using System.Collections.Generic;

namespace SuperFacil.Dominio.Modelos.Administracao
{

    public class Adm_Empresa 
    {
        #region - Construtor -       
        public Adm_Empresa()
        {
            this.Perfil = new List<Adm_Perfil>();
            this.Usuario = new List<Adm_Usuario>();
            this.HorarioAcesso = new List<Sis_HorarioAcesso>();
        }
        #endregion

        #region - Propriedade -   
        public int Empresa_ID { get; set; }
        public int? Parent_ID { get; set; }
        public string Designacao { get; set; }
        public string NIF { get; set; }
        public int Contacto_ID { get; set; }
        public int Pais_ID { get; set; }
        public int Morada_ID { get; set; }
        public int? Imagem_ID { get; set; }
        public bool Activo { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; }
        public bool Default { get; set; } = false;
        #endregion

        #region - Relacionamento -
        public virtual ICollection<Adm_Perfil> Perfil { get; set; }
        public virtual ICollection<Adm_Usuario> Usuario { get; set; }
        public virtual ICollection<Sis_HorarioAcesso> HorarioAcesso { get; set; }
        public virtual Glo_Imagem Imagem { get; set; }
        public virtual Glo_Contacto Contacto { get; set; }
        public virtual Glo_Morada Morada { get; set; }
        public virtual Glo_Pais Pais { get; set; }
       // public virtual Sis_Sessao Sessao { get; set; }
        #endregion             
    }
}
