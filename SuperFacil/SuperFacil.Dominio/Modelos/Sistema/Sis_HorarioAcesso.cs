using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    public class Sis_HorarioAcesso
    {
        public Sis_HorarioAcesso()
        {
            this.Perfil = new HashSet<Adm_Perfil>();
        }
        public int HorarioAcesso_ID { get; set; }
        public int Empresa_ID { get; set; }
        public TimeSpan Hora_Inicio { get; set; }
        public TimeSpan Hora_Fim { get; set; }

        public virtual ICollection<Adm_Perfil> Perfil { get; set; }
    }
}
