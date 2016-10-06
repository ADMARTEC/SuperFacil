using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    public class Sis_HorarioAcesso
    {
        public int HorarioAcesso_ID { get; set; }
        public int Empresa_ID { get; set; }       
        public TimeSpan Hora_Inicio { get; set; }
        public TimeSpan Hora_Fim { get; set; }
    }
}
