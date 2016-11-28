using SuperFacil.Dominio.Modelos.Multimidia;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Multimidia
{
    public class Mul_Midia_Map : EntityTypeConfiguration<Mul_Midia>
    {
        public Mul_Midia_Map()
        {

            this.HasKey(x => x.Midia_ID);

            Property(x => x.Midia_ID)
            .HasColumnOrder(1)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Localizacao_ID)
             .HasColumnOrder(2)
             .IsRequired();

            Property(x => x.Parent_ID)
             .HasColumnOrder(3)
             .IsOptional();

            Property(x => x.Designacao)
              .HasColumnOrder(4)
              .IsRequired()
              .HasMaxLength(250)
              .HasColumnType("nvarchar");

            Property(x => x.Autor_ID)
                .HasColumnOrder(5)
                .IsRequired();

            Property(x => x.Ano_Lancamento)
                .HasColumnOrder(6)
                .IsOptional()
                .HasColumnType("datetime");

            Property(x => x.Editora)
                .HasColumnOrder(7)
                .IsOptional()
                .HasMaxLength(250)
                .HasColumnType("nvarchar"); 

            Property(x => x.Duracao)
                .HasColumnOrder(9)
                .IsOptional() /*Duração só precisa de 5 caraceters Ex: 03:45*/                
                .HasColumnType("Time");

            Property(x => x.Activo)
              .HasColumnOrder(10)
              .IsRequired()
              .HasColumnType("bit");

            Property(x => x.CreateUser)
               .HasColumnOrder(11)
               .IsRequired();

            Property(x => x.CreateDate)
               .HasColumnOrder(12)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.UpdateUser)
               .HasColumnOrder(13)
               .IsRequired();

            Property(x => x.UpdateDate)
               .HasColumnOrder(14)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.Deleted)
               .HasColumnOrder(15)
               .IsRequired()
               .HasColumnType("bit");

            Property(x => x.Default)
               .HasColumnOrder(16)
               .IsRequired()
               .HasColumnType("bit");
        }
    }
}
