using SuperFacil.Domain.Entities.Multimidia;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Application.Interface.Multimidia
{
    public interface IMul_Midia_AppService: IAppServiceBase<Mul_Midia>
    {
        Task<IEnumerable<Mul_Midia>> GetDesignacao(string _value);
        void GetOrganizarLocal();

    }
}
