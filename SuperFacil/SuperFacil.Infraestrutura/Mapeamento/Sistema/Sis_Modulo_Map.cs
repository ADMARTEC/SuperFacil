using SuperFacil.Dominio.Modelos.Sistema;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Sistema
{
    public class Sis_Modulo_Map : EntityTypeConfiguration<Sis_Modulo>
    {
        public Sis_Modulo_Map()
        {
            this.HasKey(x => x.Modulo_ID);

            Property(x => x.Modulo_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Aplicacao_ID)
                .IsRequired();

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
