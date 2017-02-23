using SuperFacil.Application;
using SuperFacil.Application.Interface.Inquerito;
using SuperFacil.Domain.Entities.Inquerito;
using SuperFacil.Domain.Interface.Services.Inquerito;

namespace SuperFacil.Domain.Services.Inquerito
{
    public class Inq_Inquerito_Resposta_AppService : AppServiceBase<Inq_Inquerito_Resposta>, IInq_Inquerito_Resposta_AppService
    {
        private readonly IInq_Inquerito_Resposta_Service _Service;

        public Inq_Inquerito_Resposta_AppService(IInq_Inquerito_Resposta_Service Service) : base(Service)
        {
            _Service = Service;
        }        
    }
}
