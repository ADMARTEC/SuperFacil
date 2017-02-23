using SuperFacil.Domain.Entities.Multimidia;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Domain.Interface.Repositories.Multimidia
{
    public interface IMul_Midia_Repository : IRepositoryBase<Mul_Midia>
    {
        Task<IEnumerable<Mul_Midia>> GetDesignacao(string _value);
        void GetOrganizarLocal();

    }
}
