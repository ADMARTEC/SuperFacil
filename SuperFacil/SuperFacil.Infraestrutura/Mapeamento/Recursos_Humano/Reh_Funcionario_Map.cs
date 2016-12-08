using SuperFacil.Dominio.Modelos.Recursos_Humano;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Recursos_Humano
{
    public class Reh_Funcionario_Map: EntityTypeConfiguration<Reh_Funcionario>
    {
        public Reh_Funcionario_Map()
        {
            this.HasKey(x=> x.Funcionario_ID);

            Property(x => x.Funcionario_ID)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)
                .IsRequired();          

            Property(x => x.Nome)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(x => x.Sobrenome)
               .HasMaxLength(50)
               .HasColumnType("nvarchar")
               .IsRequired();

            Property(x => x.DataNascimento)
              .IsRequired()
              .HasColumnType("datetime");

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
