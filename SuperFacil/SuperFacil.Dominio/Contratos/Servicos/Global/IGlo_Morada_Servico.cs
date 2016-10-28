using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Global
{
    public interface IGlo_Morada_Servico : IDisposable
    {
        Glo_Morada GetByID(int _Empresa, int value);
        Glo_Morada GetByPais(int _Empresa, int value);
        Glo_Morada GetByDesignacao(int _Empresa, string value);
        Glo_Morada GetByClass(int _Empresa, int _Class_ID, string _ClasseNome);

        void Create(Glo_Morada morada);
        void Update(Glo_Morada morada);
        void Deleted(Glo_Morada morada);
    }
}
