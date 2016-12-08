using SuperFacil.Dominio.Modelos.Global;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Global
{
    public class Glo_Imagem_Map : EntityTypeConfiguration<Glo_Imagem>
    {
        public Glo_Imagem_Map()
        {
            this.HasKey(x => x.Imagem_ID);

            Property(x => x.Imagem_ID)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Designacao)
                .IsVariableLength()
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
