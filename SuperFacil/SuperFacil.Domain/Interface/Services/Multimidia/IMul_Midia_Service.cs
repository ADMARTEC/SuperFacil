using SuperFacil.Domain.Entities.Multimidia;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Domain.Interface.Services.Multimidia
{
    public interface IMul_Midia_Service:IServiceBase<Mul_Midia>
    {
        Task<IEnumerable<Mul_Midia>> GetDesignacao(string _value);
        void GetOrganizarLocal();

    }
}
