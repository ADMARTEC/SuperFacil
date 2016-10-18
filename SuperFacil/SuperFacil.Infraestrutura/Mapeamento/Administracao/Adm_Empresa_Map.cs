using SuperFacil.Dominio.Modelos.Administracao;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Administracao
{
    public class Adm_Empresa_Map : EntityTypeConfiguration<Adm_Empresa>
    {
        public Adm_Empresa_Map()
        {
            this.HasKey(x => x.Empresa_ID);

            Property(x => x.Empresa_ID)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Parent_ID)
                .HasColumnOrder(2)
                .IsOptional();

            Property(x => x.Designacao)
                .HasColumnOrder(3)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("nvarchar");

            Property(x => x.NIF)
                .HasColumnOrder(4)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("nvarchar");

            Property(x => x.Contacto_ID)
                .HasColumnOrder(5)
                .IsOptional();

            Property(x => x.Pais_ID)
                .HasColumnOrder(6)
                .IsRequired();

            Property(x => x.Morada_ID)
                .HasColumnOrder(7)
                .IsRequired();

            Property(x => x.Activo)
               .HasColumnOrder(8)
               .IsRequired()
               .HasColumnType("bit");

            Property(x => x.CreateUser)
               .HasColumnOrder(9)
               .IsRequired();

            Property(x => x.CreateDate)
               .HasColumnOrder(10)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.UpdateUser)
               .HasColumnOrder(11)
               .IsRequired();

            Property(x => x.UpdateDate)
               .HasColumnOrder(12)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.Deleted)
               .HasColumnOrder(13)
               .IsRequired()
               .HasColumnType("bit");

            Property(x => x.Default)
               .HasColumnOrder(14)
               .IsRequired()
               .HasColumnType("bit");
        }
    }
}
