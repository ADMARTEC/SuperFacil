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
    public class Mul_Localizacao_Map : EntityTypeConfiguration<Mul_Localizacao>
        {
        public Mul_Localizacao_Map()
            {

            Property(x => x.Localizacao_ID)
           .HasColumnOrder(1)
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)
           .HasColumnOrder(2)
           .IsRequired();

            Property(x => x.Parent_ID)
           .HasColumnOrder(3)
           .IsRequired();

            Property(x => x.Designacao)
           .HasColumnOrder(4)
           .IsRequired()
           .HasMaxLength(250)
           .HasColumnType("nvarchar");

            }
        }
    }
