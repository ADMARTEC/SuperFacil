using SuperFacil.Dominio.Modelos.Abstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Multimidia
{
    /*
   * Propriedades Abstratas a ter em conta:
   * Título, Classificação e Genero
   * Create,Update e Deleted --- Nunca deve faltar em nenhuma classe
   */
    public class Mul_Musica : Abs_Objecto
    {
        #region Propriedade
        public int Musica_ID { get; set; }
        public int Album_ID { get; set; }
        public int Faixa { get; set; }
        public string Duracao { get; set; }
        //Importante na pesquisa dos albums, tag é uma etiqueta, exemplo: "Musica Calma", "Musica de Amor"
        public string Tag { get; set; }
        public string Estado { get; set; }
        #endregion

    }
}
