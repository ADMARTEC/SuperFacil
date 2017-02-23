using SuperFacil.Application.Interface.Multimidia;
using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Domain.Interface.Services.Multimidia;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Application.Multimidia
{
    public class Mul_Autor_AppService : AppServiceBase<Mul_Autor>, IMul_Autor_AppService
    {
        private readonly IMul_Autor_Service _service;

        public Mul_Autor_AppService(IMul_Autor_Service Service) : base(Service)
        {
            _service = Service;
        }      

        public async Task<IEnumerable<Mul_Autor>> Autor_Especial()
        {
            return _service.Autor_Especial(await _service.GetAll());
        }         
      
    }
}
