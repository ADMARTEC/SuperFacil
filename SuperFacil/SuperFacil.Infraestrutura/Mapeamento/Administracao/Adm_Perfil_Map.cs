using SuperFacil.Dominio.Modelos.Administracao;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Administracao
{
    public class Adm_Perfil_Map : EntityTypeConfiguration<Adm_Perfil>
    {
        public Adm_Perfil_Map()
        {
            this.HasKey(x => x.Perfil_ID);

            Property(x => x.Perfil_ID)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)
                 .HasColumnOrder(2)
                 .IsRequired();

            Property(x => x.Parent_ID)
                .HasColumnOrder(3)
                .IsOptional();

            Property(x => x.Designacao)
                .HasColumnOrder(4)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("nvarchar");

            Property(x => x.HorarioAcesso_ID)
                .HasColumnOrder(5)
                .IsOptional();

            Property(x => x.Activo)
               .HasColumnOrder(6)
               .IsRequired()
               .HasColumnType("bit");

            Property(x => x.CreateUser)
               .HasColumnOrder(7)
               .IsRequired();

            Property(x => x.CreateDate)
               .HasColumnOrder(8)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.UpdateUser)
               .HasColumnOrder(9)
               .IsRequired();

            Property(x => x.UpdateDate)
               .HasColumnOrder(10)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.Deleted)
               .HasColumnOrder(11)
               .IsRequired()
               .HasColumnType("bit");

            Property(x => x.Default)
               .HasColumnOrder(12)
               .IsRequired()
               .HasColumnType("bit");
        }
    }
}
