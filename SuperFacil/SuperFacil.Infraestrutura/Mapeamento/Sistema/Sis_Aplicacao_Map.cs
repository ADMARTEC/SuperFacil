using SuperFacil.Dominio.Modelos.Sistema;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Sistema
{
    public class Sis_Aplicacao_Map : EntityTypeConfiguration<Sis_Aplicacao>
    {
        public Sis_Aplicacao_Map()
        {
            this.HasKey(x => x.Aplicacao_ID);

            Property(x => x.Aplicacao_ID)                
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Designacao)                
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnType("nvarchar");

            Property(x => x.Versao)                
                .IsRequired()
                .HasMaxLength(10)
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
