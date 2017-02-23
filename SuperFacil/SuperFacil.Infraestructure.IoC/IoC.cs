using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using SuperFacil.Application;
using SuperFacil.Application.GestEmpresa.Administracao;
using SuperFacil.Application.Interface;
using SuperFacil.Application.Interface.GestEmpresa.Administracao;
using SuperFacil.Application.Interface.Multimidia;
using SuperFacil.Application.Multimidia;
using SuperFacil.Domain.Interface;
using SuperFacil.Domain.Interface.Repositories.Multimidia;
using SuperFacil.Domain.Interface.Services.Multimidia;
using SuperFacil.Services.Multimidia;
using SuperFacil.Infrasctruture.Data.Repositories;
using SuperFacil.Infrasctruture.Data.Repositories.Multimidia;
using SuperFacil.Services;
using SuperFacil.Domain.Services.Inquerito;
using SuperFacil.Application.Interface.Inquerito;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Administracao;
using SuperFacil.Services.GestEmpresa.Administracao;
using SuperFacil.Domain.Interface.Services.Inquerito;
using SuperFacil.Services.Inquerito;
using SuperFacil.Application.Interface.Sistema;
using SuperFacil.Application.Interface.Sistema.Generico;
using SuperFacil.Domain.Services.Sistema;
using SuperFacil.Domain.Services.Sistema.Generico;
using SuperFacil.Services.Sistema;
using SuperFacil.Services.Sistema.Generico;
using SuperFacil.Domain.Interface.Services.Sistema;
using SuperFacil.Domain.Interface.Services.Sistema.Generico;
using SuperFacil.Domain.Interface.Repositories.GestEmpresa.Administracao;
using SuperFacil.Domain.Interface.Repositories.Inquerito;
using SuperFacil.Domain.Interface.Repositories.Sistema;
using SuperFacil.Domain.Interface.Repositories.Sistema.Generico;
using SuperFacil.Infrasctruture.Data.Repositories.GestEmpresa.Administracao;
using SuperFacil.Infrasctruture.Data.Repositories.Inquerito;
using SuperFacil.Infrasctruture.Data.Repositories.Sistema;
using SuperFacil.Infrasctruture.Data.Repositories.Sistema.Generico;
using SuperFacil.Application.Interface.GestEmpresa.Comercial.Artigo;
using SuperFacil.Application.GestEmpresa.Comercial.Artigo;
using SuperFacil.Application.Interface.GestEmpresa.Comercial.Cliente;
using SuperFacil.Application.GestEmpresa.Comercial.Cliente;
using SuperFacil.Application.Interface.GestEmpresa.Comercial.Generico;
using SuperFacil.Application.GestEmpresa.Comercial.Generico;
using SuperFacil.Application.GestEmpresa.Financas.Bancos;
using SuperFacil.Application.Interface.GestEmpresa.Financas.Bancos;
using SuperFacil.Application.GestEmpresa.Financas.Generico;
using SuperFacil.Application.Interface.GestEmpresa.Financas.Generico;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Comercial.Artigo;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Comercial.Cliente;
using SuperFacil.Services.GestEmpresa.Comercial.Artigo;
using SuperFacil.Services.GestEmpresa.Comercial.Cliente;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Financas.Bancos;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Comercial.Generico;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Financas.Generico;
using SuperFacil.Services.GestEmpresa.Comercial.Generico;
using SuperFacil.Services.GestEmpresa.Financas.Bancos;
using SuperFacil.Services.GestEmpresa.Financas.Generico;
using SuperFacil.Domain.Interface.Repositories.GestEmpresa.Comercial.Artigo;
using SuperFacil.Infrasctruture.Data.Repositories.GestEmpresa.Comercial.Artigo;
using SuperFacil.Domain.Interface.Repositories.GestEmpresa.Comercial.Cliente;
using SuperFacil.Infrasctruture.Data.Repositories.GestEmpresa.Comercial.Cliente;
using SuperFacil.Domain.Interface.Repositories.GestEmpresa.Comercial.Generico;
using SuperFacil.Infrasctruture.Data.Repositories.GestEmpresa.Comercial.Generico;
using SuperFacil.Domain.Interface.Repositories.GestEmpresa.Financas.Bancos;
using SuperFacil.Infrasctruture.Data.Repositories.GestEmpresa.Financas.Bancos;
using SuperFacil.Domain.Interface.Repositories.GestEmpresa.Financas.Generico;
using SuperFacil.Infrasctruture.Data.Repositories.GestEmpresa.Financas.Generico;
using System.Reflection;
using SimpleInjector.Integration.Web;

namespace SuperFacil.Infraestructure.IoC
{
    public static class IoC
    {
        public static SimpleInjectorDependencyResolver Start()
        {
            var kernel = new Container();
            kernel.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // AppService

            kernel.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>), Lifestyle.Scoped);
            kernel.Register<IMul_Autor_AppService, Mul_Autor_AppService>(Lifestyle.Scoped);
            kernel.Register<IMul_Localizacao_AppService, Mul_Localizacao_AppService>(Lifestyle.Scoped);
            kernel.Register<IMul_Midia_AppService, Mul_Midia_AppService>(Lifestyle.Scoped);

            kernel.Register<IAdmin_Documento_AppService, Admin_Documento_AppService>(Lifestyle.Scoped);
            kernel.Register<IAdmin_Documento_Numero_AppService, Admin_Documento_Numero_AppService>(Lifestyle.Scoped);
            kernel.Register<IAdmin_Documento_Rodape_AppService, Admin_Documento_Rodape_AppService>(Lifestyle.Scoped);

            kernel.Register<ICom_Artigo_AppService, Com_Artigo_AppService>(Lifestyle.Scoped);
            kernel.Register<ICom_Artigo_Familia_AppService, Com_Artigo_Familia_AppService>(Lifestyle.Scoped);
            kernel.Register<ICom_Artigo_Preco_AppService, Com_Artigo_Preco_AppService>(Lifestyle.Scoped);

            kernel.Register<ICom_Cliente_AppService, Com_Cliente_AppService>(Lifestyle.Scoped);
            kernel.Register<ICom_Cliente_Contactos_AppService, Com_Cliente_Contactos_AppService>(Lifestyle.Scoped);
            kernel.Register<ICom_Cliente_Evento_AppService, Com_Cliente_Evento_AppService>(Lifestyle.Scoped);
            kernel.Register<ICom_Cliente_Evento_Tipo_AppService, Com_Cliente_Evento_Tipo_AppService>(Lifestyle.Scoped);

            kernel.Register<ICom_Gen_FormaPagamento_AppService, Com_Gen_FormaPagamento_AppService>(Lifestyle.Scoped);
            kernel.Register<ICom_Gen_PrazoPagamento_AppService, Com_Gen_PrazoPagamento_AppService>(Lifestyle.Scoped);
            kernel.Register<ICom_Gen_TabelaPreco_AppService, Com_Gen_TabelaPreco_AppService>(Lifestyle.Scoped);

            kernel.Register<IFin_Banco_AppService, Fin_Banco_AppService>(Lifestyle.Scoped);
            kernel.Register<IFin_Banco_Conta_AppService, Fin_Banco_Conta_AppService>(Lifestyle.Scoped);
            kernel.Register<IFin_Banco_Conta_TPA_AppService, Fin_Banco_Conta_TPA_AppService>(Lifestyle.Scoped);

            kernel.Register<IFin_Gen_Moeda_AppService, Fin_Gen_Moeda_AppService>(Lifestyle.Scoped);
            kernel.Register<IFin_Gen_Moeda_Cambio_AppService, Fin_Gen_Moeda_Cambio_AppService>(Lifestyle.Scoped);

            kernel.Register<IInq_Inquerito_AppService, Inq_Inquerito_AppService>(Lifestyle.Scoped);
            kernel.Register<IInq_Inquerito_Pergunta_AppService, Inq_Inquerito_Pergunta_AppService>(Lifestyle.Scoped);
            kernel.Register<IInq_Inquerito_Pergunta_Categoria_AppService, Inq_Inquerito_Pergunta_Categoria_AppService>(Lifestyle.Scoped);
            kernel.Register<IInq_Inquerito_Resposta_AppService, Inq_Inquerito_Resposta_AppService>(Lifestyle.Scoped);
            kernel.Register<IInq_Questionario_AppService, Inq_Questionario_AppService>(Lifestyle.Scoped);
            kernel.Register<IInq_Questionario_Resposta_AppService, Inq_Questionario_Resposta_AppService>(Lifestyle.Scoped);

            kernel.Register<ISis_Empresa_AppService, Sis_Empresa_AppService>(Lifestyle.Scoped);
            kernel.Register<ISis_Gen_Pais_AppService, Sis_Gen_Pais_AppService>(Lifestyle.Scoped);

            // Service

            kernel.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Scoped);
            kernel.Register<IMul_Autor_Service, Mul_Autor_Service>(Lifestyle.Scoped);
            kernel.Register<IMul_Midia_Service, Mul_Midia_Service>(Lifestyle.Scoped);
            kernel.Register<IMul_Localizacao_Service, Mul_Localizacao_Service>(Lifestyle.Scoped);

            kernel.Register<IAdmin_Documento_Service, Admin_Documento_Service>(Lifestyle.Scoped);
            kernel.Register<IAdmin_Documento_Numero_Service, Admin_Documento_Numero_Service>(Lifestyle.Scoped);
            kernel.Register<IAdmin_Documento_Rodape_Service, Admin_Documento_Rodape_Service>(Lifestyle.Scoped);

            kernel.Register<ICom_Artigo_Service, Com_Artigo_Service>(Lifestyle.Scoped);
            kernel.Register<ICom_Artigo_Familia_Service, Com_Artigo_Familia_Service>(Lifestyle.Scoped);
            kernel.Register<ICom_Artigo_Preco_Service, Com_Artigo_Preco_Service>(Lifestyle.Scoped);

            kernel.Register<ICom_Cliente_Service, Com_Cliente_Service>(Lifestyle.Scoped);
            kernel.Register<ICom_Cliente_Contactos_Service, Com_Cliente_Contactos_Service>(Lifestyle.Scoped);
            kernel.Register<ICom_Cliente_Evento_Service, Com_Cliente_Evento_Service>(Lifestyle.Scoped);
            kernel.Register<ICom_Cliente_Evento_Tipo_Service, Com_Cliente_Evento_Tipo_Service>(Lifestyle.Scoped);

            kernel.Register<ICom_Gen_FormaPagamento_Service, Com_Gen_FormaPagamento_Service>(Lifestyle.Scoped);
            kernel.Register<ICom_Gen_PrazoPagamento_Service, Com_Gen_PrazoPagamento_Service>(Lifestyle.Scoped);
            kernel.Register<ICom_Gen_TabelaPreco_Service, Com_Gen_TabelaPreco_Service>(Lifestyle.Scoped);

            kernel.Register<IFin_Banco_Service, Fin_Banco_Service>(Lifestyle.Scoped);
            kernel.Register<IFin_Banco_Conta_Service, Fin_Banco_Conta_Service>(Lifestyle.Scoped);
            kernel.Register<IFin_Banco_Conta_TPA_Service, Fin_Banco_Conta_TPA_Service>(Lifestyle.Scoped);

            kernel.Register<IFin_Gen_Moeda_Service, Fin_Gen_Moeda_Service>(Lifestyle.Scoped);
            kernel.Register<IFin_Gen_Moeda_Cambio_Service, Fin_Gen_Moeda_Cambio_Service>(Lifestyle.Scoped);

            kernel.Register<IInq_Inquerito_Service, Inq_Inquerito_Service>(Lifestyle.Scoped);
            kernel.Register<IInq_Inquerito_Pergunta_Service, Inq_Inquerito_Pergunta_Service>(Lifestyle.Scoped);
            kernel.Register<IInq_Inquerito_Pergunta_Categoria_Service, Inq_Inquerito_Pergunta_Categoria_Service>(Lifestyle.Scoped);
            kernel.Register<IInq_Inquerito_Resposta_Service, Inq_Inquerito_Resposta_Service>(Lifestyle.Scoped);
            kernel.Register<IInq_Questionario_Service, Inq_Questionario_Service>(Lifestyle.Scoped);
            kernel.Register<IInq_Questionario_Resposta_Service, Inq_Questionario_Resposta_Service>(Lifestyle.Scoped);

            kernel.Register<ISis_Empresa_Service, Sis_Empresa_Service>(Lifestyle.Scoped);
            kernel.Register<ISis_Gen_Pais_Service, Sis_Gen_Pais_Service>(Lifestyle.Scoped);

            // Repositorio

            kernel.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), Lifestyle.Scoped);
            kernel.Register<IMul_Autor_Repository, Mul_Autor_Repository>(Lifestyle.Scoped);
            kernel.Register<IMul_Midia_Repository, Mul_Midia_Repository>(Lifestyle.Scoped);
            kernel.Register<IMul_Localizacao_Repository, Mul_Localizacao_Repository>(Lifestyle.Scoped);

            kernel.Register<IAdmin_Documento_Repository, Admin_Documento_Repository>(Lifestyle.Scoped);
            kernel.Register<IAdmin_Documento_Numero_Repository, Admin_Documento_Numero_Repository>(Lifestyle.Scoped);
            kernel.Register<IAdmin_Documento_Rodape_Repository, Admin_Documento_Rodape_Repository>(Lifestyle.Scoped);

            kernel.Register<ICom_Artigo_Repository, Com_Artigo_Repository>(Lifestyle.Scoped);
            kernel.Register<ICom_Artigo_Familia_Repository, Com_Artigo_Familia_Repository>(Lifestyle.Scoped);
            kernel.Register<ICom_Artigo_Preco_Repository, Com_Artigo_Preco_Repository>(Lifestyle.Scoped);

            kernel.Register<ICom_Cliente_Repository, Com_Cliente_Repository>(Lifestyle.Scoped);
            kernel.Register<ICom_Cliente_Contactos_Repository, Com_Cliente_Contactos_Repository>(Lifestyle.Scoped);
            kernel.Register<ICom_Cliente_Evento_Repository, Com_Cliente_Evento_Repository>(Lifestyle.Scoped);
            kernel.Register<ICom_Cliente_Evento_Tipo_Repository, Com_Cliente_Evento_Tipo_Repository>(Lifestyle.Scoped);

            kernel.Register<ICom_Gen_FormaPagamento_Repository, Com_Gen_FormaPagamento_Repository>(Lifestyle.Scoped);
            kernel.Register<ICom_Gen_PrazoPagamento_Repository, Com_Gen_PrazoPagamento_Repository>(Lifestyle.Scoped);
            kernel.Register<ICom_Gen_TabelaPreco_Repository, Com_Gen_TabelaPreco_Repository>(Lifestyle.Scoped);

            kernel.Register<IFin_Banco_Repository, Fin_Banco_Repository>(Lifestyle.Scoped);
            kernel.Register<IFin_Banco_Conta_Repository, Fin_Banco_Conta_Repository>(Lifestyle.Scoped);
            kernel.Register<IFin_Banco_Conta_TPA_Repository, Fin_Banco_Conta_TPA_Repository>(Lifestyle.Scoped);

            kernel.Register<IFin_Gen_Moeda_Repository, Fin_Gen_Moeda_Repository>(Lifestyle.Scoped);
            kernel.Register<IFin_Gen_Moeda_Cambio_Repository, Fin_Gen_Moeda_Cambio_Repository>(Lifestyle.Scoped);

            kernel.Register<IInq_Inquerito_Repository, Inq_Inquerito_Repository>(Lifestyle.Scoped);
            kernel.Register<IInq_Inquerito_Pergunta_Repository, Inq_Inquerito_Pergunta_Repository>(Lifestyle.Scoped);
            kernel.Register<IInq_Inquerito_Pergunta_Categoria_Repository, Inq_Inquerito_Pergunta_Categoria_Repository>(Lifestyle.Scoped);
            kernel.Register<IInq_Inquerito_Resposta_Repository, Inq_Inquerito_Resposta_Repository>(Lifestyle.Scoped);
            kernel.Register<IInq_Questionario_Repository, Inq_Questionario_Repository>(Lifestyle.Scoped);
            kernel.Register<IInq_Questionario_Resposta_Repository, Inq_Questionario_Resposta_Repository>(Lifestyle.Scoped);

            kernel.Register<ISis_Empresa_Repository, Sis_Empresa_Repository>(Lifestyle.Scoped);
            kernel.Register<ISis_Gen_Pais_Repository, Sis_Gen_Pais_Repository>(Lifestyle.Scoped);            

            kernel.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            kernel.Verify();

            return new SimpleInjectorDependencyResolver(kernel);
        }
    }
}
