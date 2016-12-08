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
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)
             .IsRequired();

            Property(x => x.Parent_ID)
            .IsOptional();   

            Property(x => x.Designacao)              
              .IsRequired()
              .HasMaxLength(50)
              .HasColumnType("nvarchar");

            Property(x => x.Genero)
              .IsRequired()
              .HasMaxLength(50)
              .HasColumnType("nvarchar");

            Property(x => x.Autor_ID)                
                .IsRequired();

            Property(x => x.Localizacao_ID)
            .IsRequired();

            Property(x => x.Ano_Lancamento)                
                .IsOptional()
                .HasColumnType("datetime");

            Property(x => x.Editora)                
                .IsOptional()
                .HasMaxLength(250)
                .HasColumnType("nvarchar"); 

            Property(x => x.Duracao)                
                .IsOptional()                
                .HasColumnType("Time");

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
