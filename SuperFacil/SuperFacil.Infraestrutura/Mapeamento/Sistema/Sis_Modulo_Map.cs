using SuperFacil.Dominio.Modelos.Sistema;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Mapeamento.Sistema
{
    public class Sis_Modulo_Map : EntityTypeConfiguration<Sis_Modulo>
    {
        public Sis_Modulo_Map()
        {
            this.HasKey(x => x.Modulo_ID);
        }
    }
}
