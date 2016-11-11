using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Mapeamento.Multimidia
    {
    public class Mul_Biografia_Map : EntityTypeConfiguration<Mul_Biografia>
        {
        public Mul_Biografia_Map()
            {
            Property(x => x.Biografia_ID)
           .HasColumnOrder(1)
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)
           .HasColumnOrder(2)
           .IsRequired();

            }
        }
    }
