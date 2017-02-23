using SuperFacil.Application;
using SuperFacil.Application.Interface.Inquerito;
using SuperFacil.Domain.Entities.Inquerito;
using SuperFacil.Domain.Interface.Services.Inquerito;

namespace SuperFacil.Domain.Services.Inquerito
{
    public class Inq_Questionario_AppService : AppServiceBase<Inq_Questionario>, IInq_Questionario_AppService
    {
        private readonly IInq_Questionario_Service _Service;

        public Inq_Questionario_AppService(IInq_Questionario_Service Service) : base(Service)
        {
            _Service = Service;
        }        
    }
}
