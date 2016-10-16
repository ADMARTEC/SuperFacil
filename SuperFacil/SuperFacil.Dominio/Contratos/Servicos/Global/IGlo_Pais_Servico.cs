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
        Task<Glo_Pais> GetRecursividade(int _Empresa, int value);
        Task<Glo_Pais> GetDesignacao(int _Empresa, string value);
       
        void Guardar(Glo_Pais pais);
        void Eliminado(Glo_Pais pais);
    }
}
