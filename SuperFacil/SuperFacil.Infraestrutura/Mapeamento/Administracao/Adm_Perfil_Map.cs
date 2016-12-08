using SuperFacil.Dominio.Modelos.Administracao;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Administracao
{
    public class Adm_Perfil_Map : EntityTypeConfiguration<Adm_Perfil>
    {
        public Adm_Perfil_Map()
        {
            this.HasKey(x => x.Perfil_ID);

            Property(x => x.Perfil_ID)                
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Aplicacao_ID)                
                .IsRequired();

            Property(x => x.Empresa_ID)                 
                 .IsRequired();

            Property(x => x.Parent_ID)                
                .IsOptional();

            Property(x => x.Designacao)                
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("nvarchar");

            Property(x => x.HorarioAcesso_ID)                
                .IsOptional();

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
