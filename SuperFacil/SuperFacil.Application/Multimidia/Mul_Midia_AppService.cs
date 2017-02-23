using SuperFacil.Application.Interface.Multimidia;
using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Domain.Interface.Services.Multimidia;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Application.Multimidia
{
    public class Mul_Midia_AppService : AppServiceBase<Mul_Midia>, IMul_Midia_AppService
    {
        private readonly IMul_Midia_Service _service;

        public Mul_Midia_AppService(IMul_Midia_Service service) : base(service)
        {
            _service = service;
        }     

        public async Task<IEnumerable<Mul_Midia>> GetDesignacao(string _value)
        {
            return await _service.GetDesignacao(_value);
        }       

        public void GetOrganizarLocal()
        {
            _service.GetOrganizarLocal();
        }
    }
}
