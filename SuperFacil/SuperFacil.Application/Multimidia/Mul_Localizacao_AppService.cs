using SuperFacil.Application.Interface.Multimidia;
using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Domain.Interface.Services.Multimidia;

namespace SuperFacil.Application.Multimidia
{
    public class Mul_Localizacao_AppService : AppServiceBase<Mul_Localizacao>, IMul_Localizacao_AppService
    {
        private readonly IMul_Localizacao_Service _service;

        public Mul_Localizacao_AppService(IMul_Localizacao_Service service): base(service)
        {
            _service = service;
        }     
    }
}
