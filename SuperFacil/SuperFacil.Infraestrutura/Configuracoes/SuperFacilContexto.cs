using SuperFacil.Dominio.Modelos.Administracao;
using SuperFacil.Dominio.Modelos.Comercial;
using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Dominio.Modelos.Multimidia;
using SuperFacil.Dominio.Modelos.Recursos_Humano;
using SuperFacil.Dominio.Modelos.Sistema;
using SuperFacil.Infraestrutura.Mapeamento.Administracao;
using SuperFacil.Infraestrutura.Mapeamento.Comercial;
using SuperFacil.Infraestrutura.Mapeamento.Global;
using SuperFacil.Infraestrutura.Mapeamento.Multimidia;
using SuperFacil.Infraestrutura.Mapeamento.Recursos_Humano;
using SuperFacil.Infraestrutura.Mapeamento.Sistema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SuperFacil.Infraestrutura
{
    public class SuperFacilContexto : DbContext
    {
        #region - Construtor -
        public SuperFacilContexto() : base("ConexaoString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            // Carregamento das informações predefinidas
            Database.SetInitializer(new SuperFacilInicializador());
        }
        #endregion

        #region - Tabelas -
        public DbSet<Adm_Usuario> Adm_Usuario { get; set; }
        public DbSet<Adm_Empresa> Adm_Empresa { get; set; }
        public DbSet<Adm_Perfil> Adm_Perfil { get; set; }
        public DbSet<Glo_Pais> Glo_Pais { get; set; }
        public DbSet<Glo_Morada> Glo_Morada { get; set; }
        public DbSet<Glo_Contacto> Glo_Contacto { get; set; }
        public DbSet<Glo_Imagem> Glo_Imagem { get; set; }
        public DbSet<Mul_Midia> Mul_Midia { get; set; }
        public DbSet<Com_Localizacao> Com_Localizacao { get; set; }
        public DbSet<Glo_Nota> Glo_Nota { get; set; }
        public DbSet<Mul_Autor> Mul_Autor { get; set; }
        public DbSet<Reh_Funcionario> Reh_Funcionario { get; set; }
        public DbSet<Sis_HorarioAcesso> Sis_HorarioAcesso { get; set; }
        public DbSet<Sis_Menu> Sis_Menu { get; set; }
        public DbSet<Sis_Modulo> Sis_Modulo { get; set; }
        public DbSet<Sis_Sessao> Sis_Sessao { get; set; }
        public DbSet<Sis_Aplicacao> Sis_Aplicacao { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new Glo_Nota_Map());
            modelBuilder.Configurations.Add(new Sis_Menu_Map());
            modelBuilder.Configurations.Add(new Glo_Pais_Map());
            modelBuilder.Configurations.Add(new Mul_Autor_Map());
            modelBuilder.Configurations.Add(new Mul_Midia_Map());
            modelBuilder.Configurations.Add(new Adm_Perfil_Map());
            modelBuilder.Configurations.Add(new Glo_Morada_Map());
            modelBuilder.Configurations.Add(new Glo_Imagem_Map());
            modelBuilder.Configurations.Add(new Sis_Modulo_Map());
            modelBuilder.Configurations.Add(new Sis_Sessao_Map());
            modelBuilder.Configurations.Add(new Adm_Empresa_Map());
            modelBuilder.Configurations.Add(new Adm_Usuario_Map());
            modelBuilder.Configurations.Add(new Glo_Contacto_Map());
            modelBuilder.Configurations.Add(new Sis_Aplicacao_Map());
            modelBuilder.Configurations.Add(new Com_Localizacao_Map());
            modelBuilder.Configurations.Add(new Reh_Funcionario_Map());          
            modelBuilder.Configurations.Add(new Sis_HorarioAcesso_Map());           

            base.OnModelCreating(modelBuilder);
        }

    }
}
