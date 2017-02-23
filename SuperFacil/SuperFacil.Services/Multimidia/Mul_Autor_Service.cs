using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Domain.Interface.Repositories.Multimidia;
using SuperFacil.Domain.Interface.Services.Multimidia;
using System.Collections.Generic;
using System.Linq;

namespace SuperFacil.Services.Multimidia
{
    public class Mul_Autor_Service : ServiceBase<Mul_Autor>, IMul_Autor_Service
    {
        private readonly IMul_Autor_Repository _Repository;

        public Mul_Autor_Service(IMul_Autor_Repository Repository):base(Repository)
        {
            _Repository = Repository;
        }      

        public IEnumerable<Mul_Autor> Autor_Especial(IEnumerable<Mul_Autor> _autores)
        {
            return _autores.Where(x => x.AutorEspecial(x));
        }       

    }
}
