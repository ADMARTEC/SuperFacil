using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Repositorios.Global
{
    public interface IGlo_Contacto_Repositorio: IDisposable
    {
        Task<Glo_Contacto> GetByID(int _Empresa, int value);
        Task<Glo_Contacto> GetByTelefone(int _Empresa, int value);
        Task<Glo_Contacto> GetByEmail(int _Empresa, string value);
        Task<Glo_Contacto> GetByResponsavel(int _Empresa, string value);
        Task<Glo_Contacto> GetByTelefoneEmail(int _Empresa, int _Telefone, string _Email);



        void Create(Glo_Contacto contacto);
        void Update(Glo_Contacto contacto);
        void Deleted(Glo_Contacto contacto);
    }
}
