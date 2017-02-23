using SuperFacil.Application;
using SuperFacil.Application.Interface.Sistema.Generico;
using SuperFacil.Domain.Entities.Sistema.Generico;
using SuperFacil.Domain.Interface.Services.Sistema.Generico;

namespace SuperFacil.Domain.Services.Sistema.Generico
{
    public class Sis_Gen_Pais_AppService : AppServiceBase<Sis_Gen_Pais>, ISis_Gen_Pais_AppService
    {
        private readonly ISis_Gen_Pais_Service _Service;

        public Sis_Gen_Pais_AppService(ISis_Gen_Pais_Service Service) : base(Service)
        {
            _Service = Service;
        }        
    }
}
