using SuperFacil.Dominio.Contratos.Servicos.Multimidia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Multimidia;

namespace SuperFacil.Bussines.Servicos.Multimidia
{   
    public class Mul_Biografia_Servico : IMul_Biografia_Servico
    {
        public Mul_Biografia GetID(string Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public Mul_Biografia GetNota(string Empresa, string value)
        {
            throw new NotImplementedException();
        }

        public int GetUsuario(string _Empresa, string _Usuario)
        {
            throw new NotImplementedException();
        }

        public int GetEmpresa(string _Empresa)
        {
            throw new NotImplementedException();
        }
        public void Create(string _Empresa, string _Nota, string _CreateUser, bool _Default)
        {
            throw new NotImplementedException();
        }

        public void Update(string _Empresa, string _Nota, string _UpdateUser, bool _Activo, bool _Default)
        {
            throw new NotImplementedException();
        }
        public void Save(string _Empresa, string _Nota, string _User, bool _Activo, bool _Default)
        {
            throw new NotImplementedException();
        }
        public void Delete(string _Empresa, int _BiografiaID)
        {
            throw new NotImplementedException();
        }

        public void Delete(string _Empresa, string _Nota)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


    }
}
