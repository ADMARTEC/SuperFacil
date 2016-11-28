using SuperFacil.Dominio.Modelos.Sistema;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Sistema
{
    public class Sis_Aplicacao_Map : EntityTypeConfiguration<Sis_Aplicacao>
    {
        public Sis_Aplicacao_Map()
        {
            this.HasKey(x => x.Aplicacao_ID);

            Property(x => x.Aplicacao_ID)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Designacao)
                .HasColumnOrder(2)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnType("nvarchar");

            Property(x => x.Versao)
                .HasColumnOrder(3)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("nchar");

            Property(x => x.Activo)
             .HasColumnOrder(4)
             .IsRequired()
             .HasColumnType("bit");

            Property(x => x.CreateUser)
               .HasColumnOrder(5)
               .IsRequired();

            Property(x => x.CreateDate)
               .HasColumnOrder(6)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.UpdateUser)
               .HasColumnOrder(7)
               .IsRequired();

            Property(x => x.UpdateDate)
               .HasColumnOrder(8)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.Deleted)
               .HasColumnOrder(9)
               .IsRequired()
               .HasColumnType("bit");

            Property(x => x.Default)
               .HasColumnOrder(10)
               .IsRequired()
               .HasColumnType("bit");
        }
    }
}
