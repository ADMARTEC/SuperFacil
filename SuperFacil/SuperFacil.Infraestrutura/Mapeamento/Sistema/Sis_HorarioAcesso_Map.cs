using SuperFacil.Dominio.Modelos.Sistema;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Infraestrutura.Mapeamento.Sistema
{
    public class Sis_HorarioAcesso_Map:EntityTypeConfiguration<Sis_HorarioAcesso>
    {
        public Sis_HorarioAcesso_Map()
        {
            this.HasKey(x=> x.HorarioAcesso_ID);

            Property(x => x.HorarioAcesso_ID)
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa_ID)
                .IsRequired();

            Property(x => x.Primeiro_Dia)              
               .IsRequired();

            Property(x => x.Ultimo_Dia) 
               .IsRequired();

            Property(x => x.Hora_Inicio)
               .HasColumnType("time")
               .IsRequired();

            Property(x => x.Hora_Fim)
               .HasColumnType("time")
               .IsRequired();

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
