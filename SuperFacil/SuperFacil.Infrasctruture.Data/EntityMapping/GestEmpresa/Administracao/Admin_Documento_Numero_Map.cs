using SuperFacil.Domain.Entities.GestEmpresa.Administracao;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Administracao
{
    public class Admin_Documento_Numero_Map : EntityTypeConfiguration<Admin_Documento_Numero>
    {
        public Admin_Documento_Numero_Map()
        {
            this.HasKey(x => x.DocumentoNumero_ID);

            Property(x => x.DocumentoNumero_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Documento_ID)
                .IsRequired();

            Property(x => x.Start)
                .IsRequired();

            Property(x => x.Last_Used)
                .IsRequired();
         
            Property(x => x.Numero)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}
