using SuperFacil.Application;
using SuperFacil.Application.Interface.Sistema;
using SuperFacil.Domain.Entities.Sistema;
using SuperFacil.Domain.Interface.Services.Sistema;

namespace SuperFacil.Domain.Services.Sistema
{
    public class Sis_Empresa_AppService : AppServiceBase<Sis_Empresa>, ISis_Empresa_AppService
    {
        private readonly ISis_Empresa_Service _Service;

        public Sis_Empresa_AppService(ISis_Empresa_Service Service) : base(Service)
        {
            _Service = Service;
        }
    }
}
