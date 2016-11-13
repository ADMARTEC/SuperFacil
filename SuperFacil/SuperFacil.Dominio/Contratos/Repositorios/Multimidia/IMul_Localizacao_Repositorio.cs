using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Repositorios.Multimidia
{
    public interface IMul_Localizacao_Repositorio : IDisposable
    {
        #region -Selecionar-
        Task<Mul_Localizacao> GetByID(int Empresa, int value);
        Task<Mul_Localizacao> GetByDesignacao(int Empresa, string value);
        #endregion

        #region CUD
        void Create(Mul_Localizacao localizacao);
        void Update(Mul_Localizacao localizacao);
        void Deleted(Mul_Localizacao localizacao);
        #endregion
    }
}
