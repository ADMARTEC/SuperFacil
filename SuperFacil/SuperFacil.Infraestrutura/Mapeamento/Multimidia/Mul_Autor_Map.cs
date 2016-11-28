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
    public class Mul_Autor_Map : EntityTypeConfiguration<Mul_Autor>
    {
        public Mul_Autor_Map()
        {
            this.HasKey(x => x.Autor_ID);

            Property(x => x.Autor_ID)
            .HasColumnOrder(1)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)
           .HasColumnOrder(2)
           .IsRequired();

            Property(x => x.Nota_ID)
           .HasColumnOrder(3)
           .IsRequired();

            Property(x => x.Nome)
           .HasColumnOrder(4)
           .IsRequired()
           .HasMaxLength(250)
           .HasColumnType("nvarchar");

            Property(x => x.Activo)
              .HasColumnOrder(5)
              .IsRequired()
              .HasColumnType("bit");

            Property(x => x.CreateUser)
               .HasColumnOrder(6)
               .IsRequired();

            Property(x => x.CreateDate)
               .HasColumnOrder(7)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.UpdateUser)
               .HasColumnOrder(8)
               .IsRequired();

            Property(x => x.UpdateDate)
               .HasColumnOrder(9)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.Deleted)
               .HasColumnOrder(10)
               .IsRequired()
               .HasColumnType("bit");

            Property(x => x.Default)
               .HasColumnOrder(11)
               .IsRequired()
               .HasColumnType("bit");


        }
    }
}
