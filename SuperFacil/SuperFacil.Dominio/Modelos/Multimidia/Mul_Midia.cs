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
        #region Construtor
        protected Mul_Midia() { }
        #endregion

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
        public virtual Mul_Autor Autor { get; set; }
        public virtual Mul_Localizacao Localizacao { get; set; }
        #endregion

        #region Metodos
        //Metodo para salvar midia com todos os campos.
        public void Set_Midia(string _Designacao, int _Empresa_ID, int _Localizacao_ID, int? _Parent_ID, int _Autor_ID, DateTime _AnoLancamento,
                      string _Editora, int? _Faixa, string _Tag, string _Estado)
            {
            AssertionConcern.AssertArgumentLength(_Designacao, 500, Res_Base.TagNomeSize);
            AssertionConcern.AssertArgumentNotEmpty(_Designacao, Res_Base.TagDesignacaoNull);

            this.Designacao = _Designacao;
            this.Empresa_ID = _Empresa_ID;
            this.Localizacao_ID = _Localizacao_ID;
            this.Parent_ID = _Parent_ID;
            this.Autor_ID = _Autor_ID;
            this.Ano_Lancamento = _AnoLancamento;
            this.Editora = _Editora;
            this.Faixa = _Faixa;
            this.Tag = _Tag;
            }

        // Metodos para slvar midia sem os campos menos importantes.
        public void Set_Midia(string _Designacao, int _Empresa_ID, int _Localizacao_ID, int? _Parent_ID, int _Autor_ID, int? _Faixa)
            {
            AssertionConcern.AssertArgumentLength(_Designacao, 500, Res_Base.TagNomeSize);
            AssertionConcern.AssertArgumentNotEmpty(_Designacao, Res_Base.TagDesignacaoNull);

            this.Designacao = _Designacao;
            this.Empresa_ID = _Empresa_ID;
            this.Localizacao_ID = _Localizacao_ID;
            this.Parent_ID = _Parent_ID;
            this.Autor_ID = _Autor_ID;
            this.Faixa = _Faixa;

            }

        #endregion

        }
    }
