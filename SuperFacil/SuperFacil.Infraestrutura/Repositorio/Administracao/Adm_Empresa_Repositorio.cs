using SuperFacil.Dominio.Contratos.Repositorios.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Administracao;

namespace SuperFacil.Infraestrutura.Repositorio.Administracao
{
    public class Adm_Empresa_Repositorio : IAdm_Empresa_Repositorio
    {
        public void Create(Adm_Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public void Deleted(Adm_Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Adm_Empresa> GetByID(int value)
        {
            throw new NotImplementedException();
        }

        public Task<Adm_Empresa> GetByNIF(int Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public Task<Adm_Empresa> GetByParent(int Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public void Update(Adm_Empresa empresa)
        {
            throw new NotImplementedException();
        }
    }
}
