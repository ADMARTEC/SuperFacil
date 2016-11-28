using SuperFacil.Dominio.Modelos.Recursos_Humano;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Mapeamento.Recursos_Humano
{
    public class Reh_Funcionario_Map: EntityTypeConfiguration<Reh_Funcionario>
    {
        public Reh_Funcionario_Map()
        {
            this.HasKey(x=> x.Funcionario_ID);
        }
    }
}
