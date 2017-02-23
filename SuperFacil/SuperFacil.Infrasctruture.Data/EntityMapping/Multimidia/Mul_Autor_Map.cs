using SuperFacil.Domain.Entities.Multimidia;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.Multimidia
{
    public class Mul_Autor_Map: EntityTypeConfiguration<Mul_Autor>
    {
        public Mul_Autor_Map()
        {
            this.HasKey(x => x.Autor_ID);

            Property(x => x.Autor_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasMaxLength(150)
                .IsRequired();

            Property(x => x.Activo)
                .IsRequired();

            Property(x => x.CreateUser)
               .IsRequired();

            Property(x => x.CreateDate)
               .IsRequired();

            Property(x => x.UpdateUser)
               .IsRequired();

            Property(x => x.UpdateDate)
               .IsRequired();

            Property(x => x.Deleted)
               .IsRequired();

            Property(x => x.Default)
               .IsRequired();
        }
    }
}
