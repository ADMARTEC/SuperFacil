using SuperFacil.Domain.Entities.Multimidia;
using System.Collections.Generic;

namespace SuperFacil.Domain.Interface.Services.Multimidia
{
    public interface IMul_Autor_Service : IServiceBase<Mul_Autor>
    {
        IEnumerable<Mul_Autor> Autor_Especial(IEnumerable<Mul_Autor> _autores);
    }
}
