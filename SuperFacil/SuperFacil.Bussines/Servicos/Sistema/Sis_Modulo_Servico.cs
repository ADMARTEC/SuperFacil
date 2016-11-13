using SuperFacil.Dominio.Contratos.Servicos.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Sistema;

namespace SuperFacil.Bussines.Servicos.Sistema
{
    public class Sis_Modulo_Servico : ISis_Modulo_Servico
    {
        public Sis_Modulo GetID(int value)
        {
            throw new NotImplementedException();
        }

        public Sis_Modulo GetDesignacao(string Parent, string value)
        {
            throw new NotImplementedException();
        }

        public int GetParent(string Parent)
        {
            throw new NotImplementedException();
        }

        public int GetUsuario(string _Empresa, string value)
        {
            throw new NotImplementedException();
        }

        public void Create(string _Parent, string _Desiginacao, string _CreateUser, bool _Default = false)
        {
            throw new NotImplementedException();
        }

        public void Update(string _Parent, string _Desiginacao, string _UpdateUser, bool _Activo, bool _Default = false)
        {
            throw new NotImplementedException();
        }

        public void Save(string _Parent, string _Desiginacao, string _UpdateUser, bool _Activo, bool _Default = false)
        {
            throw new NotImplementedException();
        }

        public void Delete(string _Parent, string _Desiginacao, string _DeleteUser)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    
    }
}
