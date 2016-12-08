using SuperFacil.Dominio.Modelos.Sistema;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Sistema
{
    public class Sis_Sessao_Map: EntityTypeConfiguration<Sis_Sessao>
    {
        public Sis_Sessao_Map()
        {
            this.HasKey(x=> x.Sessao_ID);

            Property(x => x.Sessao_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)
                .IsRequired();

            Property(x => x.Dispositivo)
              .HasMaxLength(50)
              .HasColumnType("nvarchar")
              .IsRequired();

            Property(x => x.Coordenadas)
              .IsVariableLength()
              .HasColumnType("nvarchar")
              .IsRequired();

            Property(x => x.Inicio)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.Fim)
               .IsOptional()
               .HasColumnType("datetime");

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
