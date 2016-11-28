using SuperFacil.Dominio.Modelos.Global;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Multimidia
{
    public class Glo_Nota_Map : EntityTypeConfiguration<Glo_Nota>
    {
        public Glo_Nota_Map()
        {
            this.HasKey(x => x.Nota_ID);

            Property(x => x.Nota_ID)
           .HasColumnOrder(1)
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Notas)
           .HasColumnOrder(2)
           .IsRequired()
           .HasMaxLength(500)
           .HasColumnType("nvarchar");


        }
    }
}
