using SuperFacil.Application.Interface;
using SuperFacil.Application.Interface.GestEmpresa.Administracao;
using SuperFacil.Domain.Entities.GestEmpresa.Administracao;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Application.GestEmpresa.Administracao
{
    public class Admin_Documento_AppService : IAppServiceBase<Admin_Documento>, IAdmin_Documento_AppService
    {
        public void Delete(Admin_Documento _obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Admin_Documento>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Admin_Documento> GetID(int _ID)
        {
            throw new NotImplementedException();
        }

        public void Create(Admin_Documento _obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Admin_Documento _obj)
        {
            throw new NotImplementedException();
        }
    }
}
