using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Global
{
    public interface IGlo_Pais_Servico: IDisposable
    {
        Task<Glo_Pais> GetByID(int _Empresa, int value);
        Task<Glo_Pais> GetByParent(int _Empresa, int value);
        Task<Glo_Pais> GetByDesignacao(int _Empresa, string value);
       
        void Create(Glo_Pais pais);
        void Update(Glo_Pais pais);
        void Deleted(Glo_Pais pais);
    }
}
