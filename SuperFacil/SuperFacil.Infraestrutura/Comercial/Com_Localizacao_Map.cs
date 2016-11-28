using SuperFacil.Dominio.Modelos.Comercial;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Multimidia
{
    public class Com_Localizacao_Map : EntityTypeConfiguration<Com_Localizacao>
    {
        public Com_Localizacao_Map()
        {
            this.HasKey(x=> x.Localizacao_ID);

            Property(x => x.Localizacao_ID)
           .HasColumnOrder(1)
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)
           .HasColumnOrder(2)
           .IsRequired();

            Property(x => x.Parent_ID)
           .HasColumnOrder(3)
           .IsRequired();

            Property(x => x.Designacao)
           .HasColumnOrder(4)
           .IsRequired()
           .HasMaxLength(250)
           .HasColumnType("nvarchar");

        }
    }
}
