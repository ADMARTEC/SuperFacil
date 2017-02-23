using SuperFacil.Application.Interface;
using SuperFacil.Application.Interface.GestEmpresa.Comercial.Cliente;
using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Cliente;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Application.GestEmpresa.Comercial.Cliente
{
    public class Com_Cliente_AppService : IAppServiceBase<Com_Cliente>, ICom_Cliente_AppService
    {
        public void Delete(Com_Cliente _obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Com_Cliente>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Com_Cliente> GetID(int _ID)
        {
            throw new NotImplementedException();
        }

        public void Create(Com_Cliente _obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Com_Cliente _obj)
        {
            throw new NotImplementedException();
        }
    }
}
