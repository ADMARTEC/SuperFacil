using SuperFacil.Common.Resource;
using SuperFacil.Common.Resource.Administracao;
using SuperFacil.Common.Validacao;
using SuperFacil.Dominio.Modelos.Abstracao;
using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Dominio.Modelos.Sistema;
using System.Collections.Generic;

namespace SuperFacil.Dominio.Modelos.Administracao
{
    /* 
     * Propriedades Abstratas a ter em conta:
     * Designacao,NIF
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
        public int Contacto_ID { get; set; }
        public int Pais_ID { get; set; }
        public int Morada_ID { get; set; }
        public int? Imagem_ID { get; set; }
        #endregion

        #region - Relacionamento -
        public virtual ICollection<Adm_Perfil> Perfil { get; set; }
        public virtual ICollection<Adm_Usuario> Usuario { get; set; }
        public virtual ICollection<Sis_HorarioAcesso> HorarioAcesso { get; set; }
        public virtual Glo_Imagem Imagem { get; set; }
        public virtual Glo_Contacto Contacto { get; set; }
        public virtual Glo_Morada Morada { get; set; }
        public virtual Glo_Pais Pais { get; set; }
        public virtual Sis_Sessao Sessao { get; set; }
        #endregion

        #region - Metodos -        
        public void Set_Empresa(int? _Parent, string _Designacao, string _NIF, int _Contacto, int _Pais, int _Morada, int? _Imagem)
        {
            AssertionConcern.AssertArgumentNotEmpty(_Designacao, Res_Adm_Empresa.TagNull);
            AssertionConcern.AssertArgumentNotNull(_Designacao, Res_Adm_Empresa.TagNull);
            AssertionConcern.AssertArgumentNotNull(_NIF, Res_Base.TagNIFNull);
            AssertionConcern.AssertArgumentNotEmpty(_NIF, Res_Base.TagNIFNull);

            this.Parent_ID = _Parent;
            this.Designacao = _Designacao;
            this.NIF = _NIF;
            this.Contacto_ID = _Contacto;
            this.Pais_ID = _Pais;
            this.Morada_ID = _Morada;
            this.Imagem_ID = _Imagem;
        }
        #endregion
    }
}
