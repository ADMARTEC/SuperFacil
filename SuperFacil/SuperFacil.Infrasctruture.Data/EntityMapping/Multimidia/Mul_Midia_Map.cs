using SuperFacil.Domain.Entities.Multimidia;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.Multimidia
{
    public class Mul_Midia_Map : EntityTypeConfiguration<Mul_Midia>
    {
        public Mul_Midia_Map()
        {
            this.HasKey(x => x.Midia_ID);

            Property(x => x.Midia_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
     
            Property(x => x.Designacao)
                .HasMaxLength(200)
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
