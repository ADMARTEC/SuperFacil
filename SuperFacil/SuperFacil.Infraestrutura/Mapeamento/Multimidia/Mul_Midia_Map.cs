using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
             .IsRequired();

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

            Property(x => x.Faixa)
                .HasColumnOrder(8)
                .IsOptional();

            Property(x => x.Duracao)
                .HasColumnOrder(9)
                .IsOptional()
                .HasMaxLength(5) /*Duração só precisa de 5 caraceters Ex: 03:45*/
                .HasColumnType("nvarchar");

            Property(x => x.Tag)
                .HasColumnOrder(10)
                .IsOptional()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            Property(x => x.Estado)
                .HasColumnOrder(11)
                .IsOptional()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            #region Padrão - Segundo Martinho André

            Property(x => x.Activo)
              .HasColumnOrder(12)
              .IsRequired()
              .HasColumnType("bit");

            Property(x => x.CreateUser)
               .HasColumnOrder(13)
               .IsRequired();

            Property(x => x.CreateDate)
               .HasColumnOrder(14)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.UpdateUser)
               .HasColumnOrder(15)
               .IsRequired();

            Property(x => x.UpdateDate)
               .HasColumnOrder(16)
               .IsRequired()
               .HasColumnType("datetime");

            Property(x => x.Deleted)
               .HasColumnOrder(17)
               .IsRequired()
               .HasColumnType("bit");

            Property(x => x.Default)
               .HasColumnOrder(18)
               .IsRequired()
               .HasColumnType("bit");

            #endregion

            }
        }
    }
