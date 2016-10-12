using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Repositorios.Global
{
    public interface IGlo_Contacto_Repositorio: IDisposable
    {
        Task<Glo_Contacto> GetByID(int _Empresa, int value);
        Task<Glo_Contacto> GetByTelefone(int _Empresa, int value);
        Task<Glo_Contacto> GetByClass(int _Empresa, int _Class_ID, string _ClasseNome);

        void Create(Glo_Contacto contacto);
        void Update(Glo_Contacto contacto);
        void Deleted(Glo_Contacto contacto);
    }
}
