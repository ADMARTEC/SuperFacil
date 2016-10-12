using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Multimidia
{
    public interface IMul_Midia_Servico : IDisposable

    {
        Mul_Midia GetByMidia_ID(int Empresa, int value);
        Mul_Midia GetByDesignacao(int Empresa, string value);
        void Registrar(Mul_Midia midia);

    }
}
