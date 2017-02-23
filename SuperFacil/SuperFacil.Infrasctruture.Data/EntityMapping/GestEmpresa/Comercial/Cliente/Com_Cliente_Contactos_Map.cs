using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Cliente;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Comercial.Cliente
{
    public class Com_Cliente_Contactos_Map : EntityTypeConfiguration<Com_Cliente_Contactos>
    {
        public Com_Cliente_Contactos_Map()
        {
            this.HasKey(x => x.Contactos_ID);

            Property(x => x.Contactos_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Cliente_ID)
                .IsRequired();

            Property(x => x.Telefone_Primario)
                .IsRequired();

            Property(x => x.Email_Primario)
                .IsRequired();

            Property(x => x.Telefone_Secundario)
                .IsOptional();

            Property(x => x.Email_Secundario)
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
