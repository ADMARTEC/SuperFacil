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
    }
}
