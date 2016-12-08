using SuperFacil.Dominio.Modelos.Comercial;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Comercial
{
    public class Com_Localizacao_Map : EntityTypeConfiguration<Com_Localizacao>
    {
        public Com_Localizacao_Map()
        {
            this.HasKey(x=> x.Localizacao_ID);

            Property(x => x.Localizacao_ID)           
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)           
                .IsRequired();   

            Property(x => x.Parent_ID)           
                .IsOptional();

            Property(x => x.Designacao)           
               .IsRequired()
               .HasMaxLength(50)
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
