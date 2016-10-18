using SuperFacil.Dominio.Modelos.Abstracao;
using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Dominio.Modelos.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Administracao
{
    /* 
     * Propriedades Abstratas a ter em conta:
     * Designacao,NIF,Nota
     * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
     */
    public class Adm_Empresa : Abs_Base
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
        /// <summary>
        /// Este campo deve estar presente em todas as classes, isso por causa do Multiempresa
        /// </summary>
        public int Empresa_ID { get; set; }
        public int? Parent_ID { get; set; }
        public int? Imagem_ID { get; set; }
        public int Contacto_ID { get; set; }
        public int Pais_ID { get; set; }
        public int Morada_ID { get; set; }
        #endregion

        #region - Relacionamento -
        public virtual ICollection<Adm_Perfil> Perfil { get; set; }
        public virtual ICollection<Adm_Usuario> Usuario { get; set; }
        public virtual ICollection<Sis_HorarioAcesso> HorarioAcesso { get; set; }
        public virtual Glo_Imagem Imagem { get; set; }
        public virtual Glo_Contacto Contacto { get; set; }
        public virtual Glo_Morada Morada { get; set; }
        public virtual Glo_Pais Pais { get; set; }
        #endregion
    }
}
