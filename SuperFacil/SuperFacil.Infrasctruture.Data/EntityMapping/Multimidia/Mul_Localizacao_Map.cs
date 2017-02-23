using SuperFacil.Domain.Entities.Multimidia;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.Multimidia
{
    public class Mul_Localizacao_Map : EntityTypeConfiguration<Mul_Localizacao>
    {
        public Mul_Localizacao_Map()
        {
            this.HasKey(x => x.Localizacao_ID);

            Property(x => x.Localizacao_ID)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Designacao)
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
