using SuperFacil.Domain.Entities.Multimidia;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Application.Interface.Multimidia
{
    public interface IMul_Autor_AppService : IAppServiceBase<Mul_Autor>
    {
        Task<IEnumerable<Mul_Autor>> Autor_Especial();
    }
}
