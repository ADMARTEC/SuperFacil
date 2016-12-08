using SuperFacil.Dominio.Modelos.Multimidia;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Multimidia
{
    public class Mul_Autor_Map : EntityTypeConfiguration<Mul_Autor>
    {
        public Mul_Autor_Map()
        {
            this.HasKey(x => x.Autor_ID);

            Property(x => x.Autor_ID)            
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)           
           .IsRequired();

            Property(x => x.Nota_ID)           
           .IsRequired();

            Property(x => x.Nome)           
           .IsRequired()
           .HasMaxLength(250)
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
