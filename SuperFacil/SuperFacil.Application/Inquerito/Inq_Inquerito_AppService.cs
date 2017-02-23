using SuperFacil.Application;
using SuperFacil.Application.Interface.Inquerito;
using SuperFacil.Domain.Entities.Inquerito;
using SuperFacil.Domain.Interface.Services.Inquerito;

namespace SuperFacil.Domain.Services.Inquerito
{
    public class Inq_Inquerito_AppService : AppServiceBase<Inq_Inquerito>, IInq_Inquerito_AppService
    {
        private readonly IInq_Inquerito_Service _service;

        public Inq_Inquerito_AppService(IInq_Inquerito_Service Service) : base(Service)
        {
            _service = Service;
        }       
    }
}
