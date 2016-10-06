using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Repositorios.Administracao
{
    public interface IAdm_Usuario_Repositorio : IDisposable
    {
        #region - SELECT -
        Task<Adm_Usuario> GetByID(int Empresa, int value);
        Task<Adm_Usuario> GetByLogin(int Empresa, string value);
        Task<Adm_Usuario> GetByNome(int Empresa, string value);
        Task<Adm_Usuario> GetByPerfil(int Empresa, int value);
        Task<Adm_Usuario> GetByDataLimite(int Empresa, DateTime value);
        #endregion

        #region - CUD -
        void Create(Adm_Usuario usuario);
        void Update(Adm_Usuario usuario);
        void Delete(Adm_Usuario usuario);
        #endregion
    }
}
