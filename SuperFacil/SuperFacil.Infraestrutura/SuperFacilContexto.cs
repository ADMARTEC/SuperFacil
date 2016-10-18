using SuperFacil.Dominio.Modelos.Administracao;
using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Dominio.Modelos.Multimidia;
using SuperFacil.Infraestrutura.Mapeamento.Administracao;
using SuperFacil.Infraestrutura.Mapeamento.Global;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura
    {
    public class SuperFacilContexto : DbContext
        {
        #region - Construtor -
        public SuperFacilContexto() : base("SuperFacilConexaoString")
            {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            // Carregamento das informações predefinidas
            Database.SetInitializer(new SuperFacilInicializador());
            }
        #endregion

        #region - Tabelas -
        public DbSet<Adm_Usuario> Adm_Usuario { get; set; }
        public DbSet<Mul_Midia> Mul_Midia { get; set; }
        public DbSet<Adm_Empresa> Adm_Empresa { get; set; }
        public DbSet<Adm_Perfil> Adm_Perfil { get; set; }
        public DbSet<Glo_Pais> Glo_Pais { get; set; }
        public DbSet<Glo_Morada> Glo_Morada { get; set; }
        public DbSet<Glo_Contacto> Glo_Contacto { get; set; }
        #endregion

        /// <summary>
        /// Ligação com as classes de mapeamento. Usado somente aqui nesta classe.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
            modelBuilder.Configurations.Add(new Adm_Empresa_Map());
            modelBuilder.Configurations.Add(new Adm_Perfil_Map());
            modelBuilder.Configurations.Add(new Adm_Usuario_Map());
            modelBuilder.Configurations.Add(new Glo_Contacto_Map());
            modelBuilder.Configurations.Add(new Glo_Morada_Map());
            modelBuilder.Configurations.Add(new Glo_Pais_Map());

            //base.OnModelCreating(modelBuilder);
            }

        }
    }
