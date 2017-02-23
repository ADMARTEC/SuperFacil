using SuperFacil.Domain.Entities.GestEmpresa.Financas.Bancos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Financas.Bancos
{
    public class Fin_Banco_Conta_TPA_Map : EntityTypeConfiguration<Fin_Banco_Conta_TPA>
    {
        public Fin_Banco_Conta_TPA_Map()
        {
            this.HasKey(x => x.Banco_Conta_TPA_ID);

            Property(x => x.Banco_Conta_TPA_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Banco_Conta_ID)
                .IsRequired();

            Property(x => x.Referencia)
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
