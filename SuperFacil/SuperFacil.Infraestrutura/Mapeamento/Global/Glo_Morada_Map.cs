using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Mapeamento.Global
{
    public class Glo_Morada_Map : EntityTypeConfiguration<Glo_Morada>
    {
        public Glo_Morada_Map()
        {
            this.HasKey(x => x.Morada_ID);
        }
    }
}
