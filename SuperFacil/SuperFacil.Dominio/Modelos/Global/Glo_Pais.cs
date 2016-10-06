using SuperFacil.Dominio.Modelos.Abstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Global
{
   /* 
   * Propriedades Abstratas a ter em conta:
   * Designação
   * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
   */
    public class Glo_Pais: Abs_Base
    {
        public int Pais_ID { get; set; }
        /// <summary>
        /// Se preencher este campo estará a fazer referencia a uma provincia ou municipio
        /// isso através da recursividade.
        /// </summary>
        public int Parent_ID { get; set; } 
    }
}
