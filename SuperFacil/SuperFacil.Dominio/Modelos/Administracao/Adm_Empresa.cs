using SuperFacil.Dominio.Modelos.Abstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    public class Adm_Empresa : Abs_Base
    {
        /// <summary>
        /// Este campo deve estar presente em todas as classes, isso por causa do Multiempresa
        /// </summary>
        public int Empresa_ID { get; set; }
        public int Parent_ID { get; set; }
    }
}
