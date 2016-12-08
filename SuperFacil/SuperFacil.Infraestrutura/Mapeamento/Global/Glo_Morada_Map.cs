using SuperFacil.Dominio.Modelos.Global;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Global
{
    public class Glo_Morada_Map : EntityTypeConfiguration<Glo_Morada>
    {
        public Glo_Morada_Map()
        {
            this.HasKey(x => x.Morada_ID);

            Property(x => x.Morada_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Pais_ID)
                .IsRequired();

            Property(x => x.Designacao)
                .HasMaxLength(50)                
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(x => x.Master)
                .IsOptional()
                .HasColumnType("bit");

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
