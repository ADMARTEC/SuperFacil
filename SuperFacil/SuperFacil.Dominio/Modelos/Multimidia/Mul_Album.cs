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
   * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
   */
    public class Mul_Album : Abs_Objecto
    {
        #region Propriedade
        public int Album_ID { get; set; }
        public int Localizacao_ID { get; set; }
        // Para salvar a Hierarquia, ou seja a Na Localização 1 SubLocalizacao: 2 Resultado: 1.2
        public int SubLocalizacao { get; set; }
        public int Autor_ID { get; set; }
        public string Ano_Lancamento { get; set; }
        public string Editora { get; set; }
        #endregion
    }
}
