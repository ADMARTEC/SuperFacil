using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Multimidia
    {
    public interface IMul_Autor_Servico : IDisposable
        {
        Mul_Autor GetByAutor_ID(int Empresa, int value);
        Mul_Autor GetByDesignacao(int Empresa, string value);
        void Registrar(Mul_Autor autor);
        }
    }
