using SuperFacil.Dominio.Contratos.Servicos.Multimidia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Multimidia;

namespace SuperFacil.Bussines.Servicos.Multimidia
{
    public class Mul_Localizacao_Servico : IMul_Localizacao_Servico
    {
        public Mul_Localizacao GetDesignacao(string _Empresa, string value)
        {
            throw new NotImplementedException();
        }

        public int GetEmpresa(string _Empresa)
        {
            throw new NotImplementedException();
        }

        public Mul_Localizacao GetID(string _Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public int GetParent(string _Empresa, string value)
        {
            throw new NotImplementedException();
        }

        public int GetUsuario(string _Empresa, string value)
        {
            throw new NotImplementedException();
        }
              
        public void Create(string _Empresa, string _Parent, string _Designacao, string _CreateUser, bool _Default)
        {
            throw new NotImplementedException();
        }

        public void Update(string _Empresa, string _Parent, string _Designacao, string _UpdateUser, bool _Activo, bool _Default)
        {
            throw new NotImplementedException();
        }

        public void Save(string _Empresa, string _Parent, string _Designacao, string _UpdateUser, bool _Activo, bool _Default)
        {
            throw new NotImplementedException();
        //}

        public void Delete(string _Empresa, string _Parent, string _Designacao, string _DeleteUser)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }    
    }
}
