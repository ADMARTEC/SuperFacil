using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Cliente;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Comercial.Cliente
{
    public class Com_Cliente_Map : EntityTypeConfiguration<Com_Cliente>
    {
        public Com_Cliente_Map()
        {
            this.HasKey(x => x.Cliente_ID);

            Property(x => x.Cliente_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .IsRequired();

            Property(x => x.NIF)
                .IsRequired();

            Property(x => x.Morada)
                .IsRequired();

            Property(x => x.Nota)
                .IsRequired();

            Property(x => x.Credito)
                .IsRequired();

            Property(x => x.Debito)
                .IsRequired();

            Property(x => x.Saldo)
                 .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

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
