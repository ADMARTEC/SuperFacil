using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Domain.Interface.Repositories.Multimidia;
using SuperFacil.Domain.Interface.Services.Multimidia;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Services.Multimidia
{
    public class Mul_Midia_Service : ServiceBase<Mul_Midia>, IMul_Midia_Service
    {
        private readonly IMul_Midia_Repository _Repository;

        public Mul_Midia_Service(IMul_Midia_Repository Repository):base(Repository)
        {
            _Repository = Repository;
        }
          public async Task<IEnumerable<Mul_Midia>> GetDesignacao(string _value)
        {
            return await _Repository.GetDesignacao(_value);
        }
        
        public void GetOrganizarLocal()
        {
            _Repository.GetOrganizarLocal();
        }
    }
}
