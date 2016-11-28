using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Mapeamento.Global
{
    public class Glo_Pais_Map : EntityTypeConfiguration<Glo_Pais>
    {
        public Glo_Pais_Map()
        {
            this.HasKey(x=> x.Pais_ID);
        }
    }
}
