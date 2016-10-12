using SuperFacil.Common.Resource;
using SuperFacil.Common.Validacao;
using SuperFacil.Dominio.Modelos.Abstracao;
using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Multimidia
    {
    /* 
    * Propriedades Abstratas a ter em conta:
    * Designação, Classificação e Genero
    * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
    * Nota que o titulo é representado pela Designação
    */
    public class Mul_Midia : Abs_Base
        {
        #region Propriedade
        public int Midia_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int Localizacao_ID { get; set; }
        public int? Parent_ID { get; set; }
        public int Autor_ID { get; set; }
        public DateTime Ano_Lancamento { get; set; }
        public string Editora { get; set; }
        /// Registara o número da faixa musical... Faixa 1.
        public int? Faixa { get; set; }
        public string Duracao { get; set; }
        // Para afixar etiquetas de busca em musicas, albuns, livros ou filmes... Exemplo: "Musica Calma", "Musica de Amor"
        public string Tag { get; set; }
        // O Estado ira definir se a faixa ou musica esta a ser executada ou não...
        public string Estado { get; set; }
        #endregion

        #region Relacionamento
        public virtual Adm_Empresa Empresa { get; set; }
        public virtual Mul_Autor Autor { get; set; }
        #endregion

        #region - Metodos -
        /// <summary>
        /// Atribuição dos dados completos da midia
        /// </summary>
        /// <param name="_Empresa"></param>
        /// <param name="_Localizacao"></param>
        /// <param name="_Parent"></param>
        /// <param name="_Autor"></param>
        /// <param name="_Ano_Lancamento"></param>
        /// <param name="_Editora"></param>
        /// <param name="_Faixa"></param>
        /// <param name="_Duracao"></param>
        /// <param name="_Tag"></param>
        /// <param name="_Estado"></param>
        /// <param name="_Designacao"></param>

        public void Set_Midia(int _Empresa, int _Localizacao, int _Autor, DateTime _Ano_Lancamento,
                              string _Editora, string _Duracao, string _Tag, string _Estado,
                              string _Designacao, int? _Parent = null, int? _Faixa = null)
            {

            AssertionConcern.AssertArgumentNotNull(_Designacao, Res_Base.TagDesignacaoNull);
            AssertionConcern.AssertArgumentNotEmpty(_Designacao, Res_Base.TagDesignacaoNull);

            this.Empresa_ID = _Empresa;
            this.Localizacao_ID = _Localizacao;
            this.Parent_ID = _Parent;
            this.Autor_ID = _Autor;
            this.Ano_Lancamento = _Ano_Lancamento;
            this.Editora = _Editora;
            this.Faixa = _Faixa;
            this.Duracao = _Duracao;
            this.Tag = _Tag;
            this.Estado = _Estado;
            this.Designacao = _Designacao;
            }
        #endregion
        }
    }
