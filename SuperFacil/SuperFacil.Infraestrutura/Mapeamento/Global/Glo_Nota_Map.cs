using SuperFacil.Dominio.Modelos.Global;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Global
{
    public class Glo_Nota_Map : EntityTypeConfiguration<Glo_Nota>
    {
        public Glo_Nota_Map()
        {
            this.HasKey(x => x.Nota_ID);

            Property(x => x.Nota_ID)           
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Notas)           
           .IsRequired()
           .HasMaxLength(500)
           .HasColumnType("nvarchar");

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
