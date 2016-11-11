using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Multimidia
    {
    public interface IMul_Biografia_Servico : IDisposable
        {
        Mul_Biografia GetByID(int Empresa, int value);
        Mul_Biografia GetByAutor_ID(int Empresa, int value);
        Mul_Biografia GetByDesignacao(int Empresa, string value);
        int GetEmpresa(string _Empresa);
        int GetUsuario(string _Empresa, string _Usuario);

        void Registrar(Mul_Biografia biografia);
        }
    }
