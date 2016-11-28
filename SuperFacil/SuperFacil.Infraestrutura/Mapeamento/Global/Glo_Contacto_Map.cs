using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Mapeamento.Global
{
    public class Glo_Contacto_Map : EntityTypeConfiguration<Glo_Contacto>
    {
        public Glo_Contacto_Map()
        {
            this.HasKey(x => x.Contacto_ID);
        }
    }
}
