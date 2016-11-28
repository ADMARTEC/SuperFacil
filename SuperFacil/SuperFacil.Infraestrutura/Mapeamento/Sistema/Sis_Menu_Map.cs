using SuperFacil.Dominio.Modelos.Sistema;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Mapeamento.Sistema
{
   public class Sis_Menu_Map: EntityTypeConfiguration<Sis_Menu>
    {
        public Sis_Menu_Map()
        {
            this.HasKey(x=> x.Menu_ID);
        }
    }
}
