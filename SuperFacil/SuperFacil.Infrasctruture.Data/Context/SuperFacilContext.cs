using SuperFacil.Domain.Entities.GestEmpresa.Administracao;
using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Artigo;
using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Cliente;
using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Generico;
using SuperFacil.Domain.Entities.GestEmpresa.Financas.Bancos;
using SuperFacil.Domain.Entities.GestEmpresa.Financas.Generico;
using SuperFacil.Domain.Entities.Inquerito;
using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Domain.Entities.Sistema;
using SuperFacil.Domain.Entities.Sistema.Generico;
using SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Administracao;
using SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Comercial.Artigo;
using SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Comercial.Cliente;
using SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Comercial.Generico;
using SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Financas.Bancos;
using SuperFacil.Infrasctruture.Data.EntityMapping.GestEmpresa.Financas.Generico;
using SuperFacil.Infrasctruture.Data.EntityMapping.Multimidia;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SuperFacil.Infrasctruture.Data.Context
{
    public class SuperFacilContext : DbContext
    {
        public SuperFacilContext() : base("SuperFacilConexaoString")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        #region - Tables -

        #region - Multimidia -
        public DbSet<Mul_Autor> Mul_Autor { get; set; }
        public DbSet<Mul_Midia> Mul_Midia { get; set; }
        public DbSet<Mul_Localizacao> Mul_Localizacao { get; set; }
        #endregion

        #region - Gestão Empresarial -

        #region - Administração -
        public DbSet<Admin_Documento> Admin_Documento { get; set; }
        public DbSet<Admin_Documento_Numero> Admin_Documento_Numero { get; set; }
        public DbSet<Admin_Documento_Rodape> Admin_Documento_Rodape { get; set; }
        #endregion

        #region - Comercial -

        #region - Artigo -
        public DbSet<Com_Artigo> Com_Artigo { get; set; }
        public DbSet<Com_Artigo_Familia> Com_Artigo_Familia { get; set; }
        public DbSet<Com_Artigo_Preco> Com_Artigo_Preco { get; set; }
        #endregion

        #region - Cliente -
        public DbSet<Com_Cliente> Com_Cliente { get; set; }
        public DbSet<Com_Cliente_Contactos> Com_Cliente_Contactos { get; set; }
        public DbSet<Com_Cliente_Evento_Tipo> Com_Cliente_Evento_Tipo { get; set; }
        public DbSet<Com_Cliente_Evento> Com_Cliente_Evento { get; set; }

        #endregion

        #region - Generico -
        public DbSet<Com_Gen_FormaPagamento> Com_Gen_FormaPagamento { get; set; }
        public DbSet<Com_Gen_PrazoPagamento> Com_Gen_PrazoPagamento { get; set; }
        public DbSet<Com_Gen_TabelaPreco> Com_Gen_TabelaPreco { get; set; }
        #endregion

        #endregion

        #region - Fincanças -

        #region - Bancos -
        public DbSet<Fin_Banco> Fin_Banco { get; set; }
        public DbSet<Fin_Banco_Conta> Fin_Banco_Conta { get; set; }
        public DbSet<Fin_Banco_Conta_TPA> Fin_Banco_Conta_TPA { get; set; }
        #endregion

        #region - Generico -
        public DbSet<Fin_Gen_Moeda> Fin_Gen_Moeda { get; set; }
        public DbSet<Fin_Gen_Moeda_Cambio> Fin_Gen_Moeda_Cambio { get; set; }
        #endregion

        #endregion

        #endregion

        #region - Inquerito -
        public DbSet<Inq_Inquerito> Inq_Inquerito { get; set; }
        public DbSet<Inq_Inquerito_Pergunta_Categoria> Inq_Inquerito_Pergunta_Categoria { get; set; }
        public DbSet<Inq_Inquerito_Pergunta> Inq_Inquerito_Pergunta { get; set; }
        public DbSet<Inq_Inquerito_Resposta> Inq_Inquerito_Resposta { get; set; }
        public DbSet<Inq_Questionario> Inq_Questionario { get; set; }
        public DbSet<Inq_Questionario_Resposta> Inq_Questionario_Resposta { get; set; }
        #endregion

        #region - Sistema -

        #region - Generico -
        public DbSet<Sis_Gen_Pais> Sis_Gen_Pais { get; set; }
        #endregion

        public DbSet<Sis_Empresa> Sis_Empresa { get; set; }

        #endregion
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region - Conventions -
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            #endregion

            #region - Configure DateType -
            // Sempre que usarmos string o mesmo deve reflectir ao BD os dados abaixo
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("nvarchar"));

            modelBuilder.Properties<string>()
               .Configure(p => p.HasMaxLength(100));

            modelBuilder.Properties<decimal>()
               .Configure(p => p.HasPrecision(18, 6));

            modelBuilder.Properties<bool>()
              .Configure(p => p.HasColumnType("bit"));

            modelBuilder.Properties<byte>()
              .Configure(p => p.HasColumnType("tinyint"));

            modelBuilder.Properties<short>()
            .Configure(p => p.HasColumnType("smallint"));
            #endregion

            #region - Mapping -
            modelBuilder.Configurations.Add(new Mul_Autor_Map());
            modelBuilder.Configurations.Add(new Mul_Midia_Map());
            modelBuilder.Configurations.Add(new Mul_Localizacao_Map());

            modelBuilder.Configurations.Add(new Admin_Documento_Map());
            modelBuilder.Configurations.Add(new Admin_Documento_Numero_Map());
            modelBuilder.Configurations.Add(new Admin_Documento_Rodape_Map());

            modelBuilder.Configurations.Add(new Com_Artigo_Familia_Map());
            modelBuilder.Configurations.Add(new Com_Artigo_Map());
            modelBuilder.Configurations.Add(new Com_Artigo_Preco_Map());


            modelBuilder.Configurations.Add(new Com_Cliente_Map());
            modelBuilder.Configurations.Add(new Com_Cliente_Contactos_Map());
            modelBuilder.Configurations.Add(new Com_Cliente_Evento_Map());
            modelBuilder.Configurations.Add(new Com_Cliente_Evento_Tipo_Map());
            modelBuilder.Configurations.Add(new Com_Gen_FormaPagamento_Map());
            modelBuilder.Configurations.Add(new Com_Gen_PrazoPagamento_Map());
            modelBuilder.Configurations.Add(new Com_Gen_TabelaPreco_Map());

            modelBuilder.Configurations.Add(new Fin_Banco_Map());
            modelBuilder.Configurations.Add(new Fin_Banco_Conta_Map());
            modelBuilder.Configurations.Add(new Fin_Banco_Conta_TPA_Map());
            modelBuilder.Configurations.Add(new Fin_Gen_Moeda_Cambio_Map());
            modelBuilder.Configurations.Add(new Fin_Gen_Moeda_Map());

            modelBuilder.Configurations.Add(new Inq_Inquerito_Map());
            modelBuilder.Configurations.Add(new Inq_Inquerito_Pergunta_Map());
            modelBuilder.Configurations.Add(new Inq_Inquerito_Pergunta_Categoria_Map());
            modelBuilder.Configurations.Add(new Inq_Inquerito_Resposta_Map());
            modelBuilder.Configurations.Add(new Inq_Questionario_Map());
            modelBuilder.Configurations.Add(new Inq_Questionario_Resposta_Map());

            modelBuilder.Configurations.Add(new Sis_Empresa_Map());
            modelBuilder.Configurations.Add(new Sis_Gen_Pais_Map());

            #endregion

            #region - Key -
            // <--- Configure one-to-many --->   
            // Autor
            modelBuilder.Entity<Mul_Autor>()
                .HasMany<Mul_Midia>(a => a.Midia)
                .WithRequired(m => m.Autor)
                .HasForeignKey(m => m.Autor_ID);
            // Localizacao
            modelBuilder.Entity<Mul_Localizacao>()
                .HasMany<Mul_Midia>(l => l.Midia)
                .WithRequired(m => m.Localizacao)
                .HasForeignKey(m => m.Localizacao_ID);
            
            /**/
            modelBuilder.Entity<Sis_Empresa>()
                .HasMany<Inq_Inquerito>(l => l.Inquerito)
                .WithRequired(m => m.Empresa)
                .HasForeignKey(m => m.Empresa_ID);

            modelBuilder.Entity<Sis_Gen_Pais>()
               .HasMany<Inq_Questionario>(l => l.Questionario)
               .WithRequired(m => m.Pais)
               .HasForeignKey(m => m.Pais_ID);

            modelBuilder.Entity<Inq_Inquerito>()
               .HasMany<Inq_Inquerito_Pergunta_Categoria>(l => l.Inquerito_Pergunta_Categoria)
               .WithRequired(m => m.Inquerito)
               .HasForeignKey(m => m.Inquerito_ID);

            modelBuilder.Entity<Inq_Inquerito>()
            .HasMany<Inq_Questionario>(l => l.Questionario)
            .WithRequired(m => m.Inquerito)
            .HasForeignKey(m => m.Inquerito_ID);

            modelBuilder.Entity<Inq_Inquerito_Pergunta_Categoria>()
               .HasMany<Inq_Inquerito_Pergunta>(l => l.Inquerito_Pergunta)
               .WithRequired(m => m.Inquerito_Pergunta_Categoria)
               .HasForeignKey(m => m.Inquerito_Pergunta_Categoria_ID);

            modelBuilder.Entity<Inq_Inquerito_Pergunta>()
             .HasMany<Inq_Inquerito_Resposta>(l => l.Inquerito_Resposta)
             .WithRequired(m => m.Inquerito_Pergunta)
             .HasForeignKey(m => m.Inquerito_Pergunta_ID);

            modelBuilder.Entity<Inq_Inquerito_Pergunta>()
            .HasMany<Inq_Questionario_Resposta>(l => l.Questionario_Resposta)
            .WithRequired(m => m.Inquerito_Pergunta)
            .HasForeignKey(m => m.Inquerito_Pergunta_ID);

            modelBuilder.Entity<Inq_Inquerito_Resposta>()
           .HasMany<Inq_Questionario_Resposta>(l => l.Questionario_Resposta)
           .WithRequired(m => m.Inquerito_Resposta)
           .HasForeignKey(m => m.Inquerito_Resposta_ID);

            modelBuilder.Entity<Inq_Questionario>()
             .HasMany<Inq_Questionario_Resposta>(l => l.Questionario_Resposta)
             .WithRequired(m => m.Questionario)
             .HasForeignKey(m => m.Questionario_ID);


            #endregion
        }

    }
}
