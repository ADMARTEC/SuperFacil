using SuperFacil.Dominio.Contratos.Repositorios.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Administracao;

namespace SuperFacil.Infraestrutura.Repositorio.Administracao
{
    public class Adm_Perfil_Repositorio : IAdm_Perfil_Repositorio
    {
        public void Create(Adm_Perfil perfil)
        {
            throw new NotImplementedException();
        }

        public void Deleted(Adm_Perfil perfil)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Adm_Perfil> GetByDesiginacao(int Empresa, string value)
        {
            throw new NotImplementedException();
        }

        public Task<Adm_Perfil> GetByHorarioAcesso(int Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public Task<Adm_Perfil> GetByID(int Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public Task<Adm_Perfil> GetByParent(int Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public void Update(Adm_Perfil perfil)
        {
            throw new NotImplementedException();
        }
    }
}
