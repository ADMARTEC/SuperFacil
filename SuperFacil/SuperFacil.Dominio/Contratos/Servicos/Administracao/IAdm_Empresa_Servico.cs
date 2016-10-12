using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Administracao
{
    public interface IAdm_Empresa_Servico : IDisposable
    {
        Task<Adm_Empresa> GetDesignacao(string _designacao);
        Task<Adm_Empresa> GetDesignacao(string _designacao, string _pais);
        Task<Adm_Empresa> GetDesignacao(string _designacao, string _pais, string _morada);
        Task<Adm_Empresa> GetDesigncao(string _designacao, string _nif);
        Task<Adm_Empresa> GetDesigncao(string _designacao, string _nif, int _telefone);
        Task<Adm_Empresa> GetRecursive(int value);
        Task<Adm_Empresa> GetRecursive(string _designacao);

        void Guardar(Adm_Empresa empresa);
        void Eliminar(Adm_Empresa empresa);

    }
}
