using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperFacil.Domain.Entities.Inquerito
{
    public class Inq_Questionario_Resposta_Map : EntityTypeConfiguration<Inq_Questionario_Resposta>
    {
        public Inq_Questionario_Resposta_Map()
        {
            this.HasKey(x => x.Questionario_Resposta_ID);

            Property(x => x.Questionario_Resposta_ID)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Questionario_ID)
                .IsRequired();

            Property(x => x.Inquerito_Pergunta_ID)
                .IsRequired();

            Property(x => x.Inquerito_Resposta_ID)
              .IsRequired();

            Property(x => x.Activo)
                .IsRequired();

            Property(x => x.CreateUser)
               .IsRequired();

            Property(x => x.CreateDate)
               .IsRequired();

            Property(x => x.UpdateUser)
               .IsRequired();

            Property(x => x.UpdateDate)
               .IsRequired();

            Property(x => x.DeleteUser)
                .IsOptional();

            Property(x => x.DeleteDate)
                .IsOptional();

            Property(x => x.Deleted)
               .IsRequired();

            Property(x => x.DefaultSystem)
               .IsRequired();
        }
    }
}

