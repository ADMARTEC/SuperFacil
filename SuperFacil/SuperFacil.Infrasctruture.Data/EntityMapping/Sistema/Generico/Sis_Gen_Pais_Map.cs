using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Domain.Entities.Sistema.Generico
{
    public class Sis_Gen_Pais_Map : EntityTypeConfiguration<Sis_Gen_Pais>
    {
        public Sis_Gen_Pais_Map()
        {
            this.HasKey(x => x.Pais_ID);

            Property(x => x.Pais_ID)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Provincia_ID)
                .IsOptional();

            Property(x => x.Municipio_ID)
                .IsOptional();

            Property(x => x.ISO)
             .IsOptional();     

            Property(x => x.Codigo)
                .HasMaxLength(10)
                .IsOptional();

            Property(x => x.Designacao)
                .HasMaxLength(200)
                .IsRequired();

            Property(x => x.Gps_Latitude)
                .HasMaxLength(50)
                .IsOptional();

            Property(x => x.Gps_Longitude)
               .HasMaxLength(50)
               .IsOptional();

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

            Property(x => x.DeleteUser)
                .IsOptional();

            Property(x => x.DeleteDate)
                .IsOptional();

            Property(x => x.Deleted)
               .IsRequired();

            Property(x => x.DefaultSystem)
               .IsRequired();
        }
    }
}
