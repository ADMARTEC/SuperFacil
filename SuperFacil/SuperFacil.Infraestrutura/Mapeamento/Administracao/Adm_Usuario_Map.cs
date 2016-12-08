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
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)                
                .IsRequired();

            Property(x => x.Perfil_ID)                
                .IsRequired();

            Property(x => x.Funcionario_ID)                
                .IsOptional();

            Property(x => x.Imagem_ID)
                .IsOptional();

            Property(x => x.Nome)                
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("nvarchar")
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UQ_Nome", 1) { IsUnique = true }));

            Property(x => x.Usuario_login)             
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("nvarchar")
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UQ_Login",1) { IsUnique = true }))
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UQ_Nome", 2) { IsUnique = true }));

            Property(x => x.Senha)                
                .IsRequired()
                .HasColumnType("nvarchar");

            Property(x => x.Data_Limite)                
                .IsOptional()
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
