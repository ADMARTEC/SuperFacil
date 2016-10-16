using SuperFacil.Dominio.Contratos.Repositorios.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Administracao;

namespace SuperFacil.Infraestrutura.Repositorio.Administracao
{
    public class Adm_Usuario_Repositorio : IAdm_Usuario_Repositorio
    {
        public void Create(Adm_Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Delete(Adm_Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Adm_Usuario> GetByDataLimite(int Empresa, DateTime value)
        {
            throw new NotImplementedException();
        }

        public Task<Adm_Usuario> GetByID(int Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public Task<Adm_Usuario> GetByLogin(int Empresa, string value)
        {
            throw new NotImplementedException();
        }

        public Task<Adm_Usuario> GetByNome(int Empresa, string value)
        {
            throw new NotImplementedException();
        }

        public Task<Adm_Usuario> GetByPerfil(int Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public void Update(Adm_Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
