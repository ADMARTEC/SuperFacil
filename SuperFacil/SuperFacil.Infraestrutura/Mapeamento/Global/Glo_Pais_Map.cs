using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

            Property(x => x.Pais_ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Parent_ID)
                .IsOptional();

            Property(x => x.Designacao)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(x => x.Activo)
               .IsRequired()
               .HasColumnType("bit");

            Property(x => x.CreateUser)
               .IsRequired();

            Property(x => x.CreateDate)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.UpdateUser)
               .IsRequired();

            Property(x => x.UpdateDate)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.Deleted)
               .IsRequired()
               .HasColumnType("bit");

            Property(x => x.Default)
               .IsRequired()
               .HasColumnType("bit");
        }
    }
}
