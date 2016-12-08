using SuperFacil.Dominio.Modelos.Administracao;
using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Dominio.Modelos.Sistema;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace SuperFacil.Infraestrutura
{
    public class SuperFacilInicializador : CreateDatabaseIfNotExists<SuperFacilContexto>
    {
        protected override void Seed(SuperFacilContexto context)
        {
            DateTime DataInicio = Convert.ToDateTime("2016-10-01 08:10:00");
            DateTime DataInicio_GM = Convert.ToDateTime("2016-10-01 08:10:00");

            #region - Lista Sistema -            
            var aplicacao = new List<Sis_Aplicacao>();
            var modulo = new List<Sis_Modulo>();
            var menu = new List<Sis_Menu>();
            var horacesso = new List<Sis_HorarioAcesso>();
            var sessao = new List<Sis_Sessao>();
            #endregion

            #region - Lista Global -            
            var pais = new List<Glo_Pais>();
            var morada = new List<Glo_Morada>();
            var contacto = new List<Glo_Contacto>();
            #endregion

            #region - Lista Administracao -            
            var perfil = new List<Adm_Perfil>();
            var usuario = new List<Adm_Usuario>();
            var empresa = new List<Adm_Empresa>();
            #endregion

            #region - Load Sistema -

            aplicacao.Add(new Sis_Aplicacao()
            {
                Designacao = "SuperFacil Base",
                Versao = "1.0.0.0",
                CreateUser = 1,
                Activo = true,
                CreateDate = DataInicio,
                UpdateUser = 1,
                UpdateDate = DataInicio,
                Deleted = false,
                Default = true
            });
            aplicacao.Add(new Sis_Aplicacao()
            {
                Designacao = "Gestão de Multimidia",
                Versao = "1.0.0.0",
                CreateUser = 1,
                Activo = true,
                CreateDate = DataInicio_GM,
                UpdateUser = 1,
                UpdateDate = DataInicio_GM,
                Deleted = false,
                Default = false
            });

            #endregion

            #region - Load Modulos -           
            modulo.Add(new Sis_Modulo()
            {
                Aplicacao_ID = 1,
                Designacao = "SuperFacil Generico",
                CreateUser = 1,
                Activo = true,
                CreateDate = DataInicio,
                UpdateUser = 1,
                UpdateDate = DataInicio,
                Deleted = false,
                Default = true
            });

            modulo.Add(new Sis_Modulo()
            {
                Aplicacao_ID = 2,
                Designacao = "Multimidia",
                CreateUser = 1,
                Activo = true,
                CreateDate = DataInicio_GM,
                UpdateUser = 1,
                UpdateDate = DataInicio_GM,
                Deleted = false,
                Default = false
            });
            #endregion

            #region - Load Menu -
            menu.Add(new Sis_Menu()
            {
                Parent_ID = null,
                Modulo_ID = 2,
                Designacao = "Autores",
                CreateUser = 1,
                Activo = true,
                CreateDate = DataInicio_GM,
                UpdateUser = 1,
                UpdateDate = DataInicio_GM,
                Deleted = false,
                Default = false
            });
            menu.Add(new Sis_Menu()
            {
                Parent_ID = null,
                Modulo_ID = 2,
                Designacao = "Musicas",
                CreateUser = 1,
                Activo = true,
                CreateDate = DataInicio_GM,
                UpdateUser = 1,
                UpdateDate = DataInicio_GM,
                Deleted = false,
                Default = false
            });
            menu.Add(new Sis_Menu()
            {
                Parent_ID = 2,
                Modulo_ID = 2,
                Designacao = "Discos",
                CreateUser = 1,
                Activo = true,
                CreateDate = DataInicio_GM,
                UpdateUser = 1,
                UpdateDate = DataInicio_GM,
                Deleted = false,
                Default = false
            });
            menu.Add(new Sis_Menu()
            {
                Parent_ID = 2,
                Modulo_ID = 2,
                Designacao = "Faixas",
                CreateUser = 1,
                Activo = true,
                CreateDate = DataInicio_GM,
                UpdateUser = 1,
                UpdateDate = DataInicio_GM,
                Deleted = false,
                Default = false
            });
            #endregion

            #region - Load Pais -          
            pais.Add(new Glo_Pais()
            {
                Parent_ID = null,
                Designacao = "Angola",
                CreateUser = 1,
                Activo = true,
                CreateDate = DataInicio,
                UpdateUser = 1,
                UpdateDate = DataInicio,
                Deleted = false,
                Default = false
            });
            pais.Add(new Glo_Pais()
            {
                Parent_ID = 1,
                Designacao = "Luanda",
                CreateUser = 1,
                Activo = true,
                CreateDate = DataInicio,
                UpdateUser = 1,
                UpdateDate = DataInicio,
                Deleted = false,
                Default = false
            });
            #endregion

            #region - Load Morada -
            morada.Add(new Glo_Morada()
            {
                Pais_ID = 2,
                Designacao = "Rua Conego Manuel das Neves",
                Master = true,
                CreateUser = 1,
                Activo = true,
                CreateDate = DataInicio,
                UpdateUser = 1,
                UpdateDate = DataInicio,
                Deleted = false,
                Default = false
            });
            #endregion

            #region - Load Contactos -

            contacto.Add(new Glo_Contacto()
            {
                Telefone = 925042327,
                Email = "info@superfacil.com",
                Responsavel = "Eng. Martinho Sebastião",
                Master = true,
                Activo = true,
                CreateUser = 1,
                CreateDate = DataInicio,
                UpdateUser = 1,
                UpdateDate = DataInicio,
                Deleted = false,
                Default = false
            });
            #endregion

            #region - Load Empresa -
            empresa.Add(new Adm_Empresa()
            {
                Parent_ID = null,
                Designacao = "ADMARTEC,LDA",
                NIF = "5400000000",
                Pais_ID = 2,
                Contacto_ID = 1,
                Morada_ID = 1,
                Imagem_ID = null,
                Activo = true,
                CreateUser = 1,
                CreateDate = DataInicio,
                UpdateUser = 1,
                UpdateDate = DataInicio,
                Deleted = false,
                Default = false
            });
            #endregion

            #region - Load Perfil -
            perfil.Add(new Adm_Perfil()
            {
                Aplicacao_ID = 1,
                Empresa_ID = 1,
                Parent_ID = null,
                Designacao = "Governador",
                HorarioAcesso_ID = null,
                Activo = true,
                CreateUser = 1,
                CreateDate = DataInicio,
                UpdateUser = 1,
                UpdateDate = DataInicio,
                Deleted = false,
            });
            #endregion

            #region - Load Usuario -
            usuario.Add(new Adm_Usuario()
            {
                Empresa_ID = 1,
                Perfil_ID = 1,
                Funcionario_ID = null,
                Nome = "Governador de Sistema",
                Imagem_ID = null,
                Usuario_login = "sfgovsis",
                Senha="0000000000",
                Data_Limite= null,
                Activo = true,
                CreateUser = 1,
                CreateDate = DataInicio,
                UpdateUser = 1,
                UpdateDate = DataInicio,
                Deleted = false,
            });
            #endregion

            #region - Saving Default -

            foreach (Sis_Aplicacao item in aplicacao)
                context.Sis_Aplicacao.Add(item);
            context.SaveChanges();

            foreach (Sis_Modulo item in modulo)
                context.Sis_Modulo.Add(item);
            context.SaveChanges();

            foreach (Sis_Menu item in menu)
                context.Sis_Menu.Add(item);
            context.SaveChanges();

            foreach (Glo_Pais item in pais)
                context.Glo_Pais.Add(item);
            context.SaveChanges();

            foreach (Glo_Morada item in morada)
                context.Glo_Morada.Add(item);
            context.SaveChanges();

            foreach (Glo_Contacto item in contacto)
                context.Glo_Contacto.Add(item);
            context.SaveChanges();

            foreach (Adm_Empresa item in empresa)
                context.Adm_Empresa.Add(item);
            context.SaveChanges();

            foreach (Adm_Perfil item in perfil)
                context.Adm_Perfil.Add(item);
            context.SaveChanges();

            foreach (Adm_Usuario item in usuario)
                context.Adm_Usuario.Add(item);
            context.SaveChanges();

            #endregion

            base.Seed(context);
        }
    }
}
