using SuperFacil.Dominio.Modelos.Administracao;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Administracao
{
    public class Adm_Usuario_Map : EntityTypeConfiguration<Adm_Usuario>
    {
        public Adm_Usuario_Map()
        {
            this.HasKey(x => x.Usuario_ID);

            Property(x => x.Usuario_ID)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)
                .HasColumnOrder(2)
                .IsRequired();

            Property(x => x.Perfil_ID)
                .HasColumnOrder(3)
                .IsRequired();

            Property(x => x.Funcionario_ID)
                .HasColumnOrder(4)
                .IsOptional(); // Suporta null

            Property(x => x.Nome)
                .HasColumnOrder(5)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UQ_Nome", 1) { IsUnique = true }));

            Property(x => x.Usuario_login)
                .HasColumnOrder(6)  // É opcional mais indica a ordem das colunas na base de dados
                .IsRequired() // Indica que o campo é Not null
                .HasMaxLength(20) // Tamanho maximo de caracter                
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UQ_Login") { IsUnique = true }))
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UQ_Nome", 2) { IsUnique = true }));

            Property(x => x.Senha)
                .HasColumnOrder(7)
                .IsRequired()
                .HasMaxLength(250);

            Property(x => x.Data_Limite)
                .HasColumnOrder(8)
                .IsOptional()
                .HasColumnType("datetime");

            Property(x => x.Activo)
                .HasColumnOrder(9)
                .IsRequired()
                .HasColumnType("bit");

            Property(x => x.CreateUser)
               .HasColumnOrder(10)
               .IsRequired();

            Property(x => x.CreateDate)
               .HasColumnOrder(11)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.UpdateUser)
               .HasColumnOrder(12)
               .IsRequired();

            Property(x => x.UpdateDate)
               .HasColumnOrder(13)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.Deleted)
               .HasColumnOrder(14)
               .IsRequired()
               .HasColumnType("bit");

            Property(x => x.Default)
               .HasColumnOrder(15)
               .IsRequired()
               .HasColumnType("bit");
        }
    }
}
