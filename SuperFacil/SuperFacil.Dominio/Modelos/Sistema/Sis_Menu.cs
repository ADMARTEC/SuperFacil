using SuperFacil.Dominio.Modelos.Abstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    public class Sis_Menu: Abs_Base
    {
        public int Menu_ID { get; set; }
        public int Parent_ID { get; set; }

    }
}
