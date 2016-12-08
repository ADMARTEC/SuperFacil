using SuperFacil.Dominio.Modelos.Global;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Global
{
    public class Glo_Contacto_Map : EntityTypeConfiguration<Glo_Contacto>
    {
        public Glo_Contacto_Map()
        {
            this.HasKey(x => x.Contacto_ID);

            Property(x => x.Contacto_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Telefone)
                .IsRequired();

            Property(x => x.Telefone_2)
                .IsOptional();

            Property(x => x.Email)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(x => x.Email_2)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsOptional();

            Property(x => x.Responsavel)
                .IsOptional()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

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
