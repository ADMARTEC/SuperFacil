using SuperFacil.Application.Interface;
using SuperFacil.Application.Interface.GestEmpresa.Financas.Bancos;
using SuperFacil.Domain.Entities.GestEmpresa.Financas.Bancos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Application.GestEmpresa.Financas.Bancos
{
    public class Fin_Banco_AppService : IAppServiceBase<Fin_Banco>, IFin_Banco_AppService
    {
        public void Delete(Fin_Banco _obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Fin_Banco>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Fin_Banco> GetID(int _ID)
        {
            throw new NotImplementedException();
        }

        public void Create(Fin_Banco _obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Fin_Banco _obj)
        {
            throw new NotImplementedException();
        }
    }
}
