using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Repositorios.Administracao
{
    public interface IAdm_Empresa_Repositorio: IDisposable
    {
        Task<Adm_Empresa> GetByID(int value);
        Task<Adm_Empresa> GetByParent(int Empresa, int value);
        Task<Adm_Empresa> GetByNIF(int Empresa, string value);
        Task<Adm_Empresa> GetByDesignaca(string value);


        void Create(Adm_Empresa empresa);
        void Update(Adm_Empresa empresa);
        void Deleted(Adm_Empresa empresa);

    }
}
