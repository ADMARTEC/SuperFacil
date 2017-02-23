using SuperFacil.Application;
using SuperFacil.Application.Interface.Inquerito;
using SuperFacil.Domain.Entities.Inquerito;
using SuperFacil.Domain.Interface.Services.Inquerito;

namespace SuperFacil.Domain.Services.Inquerito
{
    public class Inq_Questionario_Resposta_AppService : AppServiceBase<Inq_Questionario_Resposta>, IInq_Questionario_Resposta_AppService
    {
        private readonly IInq_Questionario_Resposta_Service _Service;

        public Inq_Questionario_Resposta_AppService(IInq_Questionario_Resposta_Service Service) : base(Service)
        {
            _Service = Service;
        }        
    }
}
