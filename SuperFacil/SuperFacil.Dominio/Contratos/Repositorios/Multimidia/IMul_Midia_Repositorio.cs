using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Repositorios.Multimidia
{
    public interface IMul_Midia_Repositorio : IDisposable
    {
        #region - Selecionar -
        Task<Mul_Midia> GetByID(int Empresa, int value);
        Task<Mul_Midia> GetByParent(int Empresa, int value);
        Task<Mul_Midia> GetByEditora(int Empresa,int? _Parent, string value);
        Task<Mul_Midia> GetByFaixa(int Empresa, int? Parent, int value);
        Task<Mul_Midia> GetByDesiginacao(int Empresa, int? _Parent, string value);
        Task<Mul_Midia> GetByGenero(int Empresa, int? _Parent, string value);
        Task<Mul_Midia> GetByEstado(int Empresa, int? _Parent, string value);
        Task<Mul_Midia> GetByTag(int Empresa, int? Parent, string value);
        Task<Mul_Midia> GetByAno_Lancamento(int Empresa, int? Parent, DateTime value);
        Task<Mul_Midia> GetByClassificacao(int Empresa, int? Parent, string value);

        #endregion

        #region -Create Update Deleted-
        void Create(Mul_Midia midia);
        void Update(Mul_Midia midia);
        void Deleted(Mul_Midia midia);
        #endregion
    }
}
