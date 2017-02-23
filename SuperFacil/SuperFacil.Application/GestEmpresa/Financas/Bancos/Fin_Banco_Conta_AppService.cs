using SuperFacil.Application.Interface;
using SuperFacil.Application.Interface.GestEmpresa.Financas.Bancos;
using SuperFacil.Domain.Entities.GestEmpresa.Financas.Bancos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Application.GestEmpresa.Financas.Bancos
{
    public class Fin_Banco_Conta_AppService : IAppServiceBase<Fin_Banco_Conta>, IFin_Banco_Conta_AppService
    {
        public void Delete(Fin_Banco_Conta _obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Fin_Banco_Conta>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Fin_Banco_Conta> GetID(int _ID)
        {
            throw new NotImplementedException();
        }

        public void Create(Fin_Banco_Conta _obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Fin_Banco_Conta _obj)
        {
            throw new NotImplementedException();
        }
    }
}
