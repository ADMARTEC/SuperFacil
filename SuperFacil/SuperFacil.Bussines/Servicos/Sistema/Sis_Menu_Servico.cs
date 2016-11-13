using SuperFacil.Dominio.Contratos.Servicos.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Sistema;

namespace SuperFacil.Bussines.Servicos.Sistema
{
    public class Sis_Menu_Servico : ISis_Menu_Servico
    {
        public Sis_Menu GetID(int value)
        {
            throw new NotImplementedException();
        }

        public Sis_Menu GetDesignacao(string _Parent, string _Modulo, string _Designacao)
        {
            throw new NotImplementedException();
        }      

        public int GetModulo(string value)
        {
            throw new NotImplementedException();
        }

        public int GetParent(string _Parent)
        {
            throw new NotImplementedException();
        }

        public int GetUsuario(string _Empresa, string value)
        {
            throw new NotImplementedException();
        }

        public void Create(string _Parent, string Modulo, string _Designacao, string _CreateUser, bool _Default = false)
        {
            throw new NotImplementedException();
        }

        public void Update(string _Parent, string Modulo, string _Designacao, string _CreateUser, bool _Activo, bool _Default = false)
        {
            throw new NotImplementedException();
        }

        public void Save(string _Parent, string Modulo, string _Designacao, string _UpdateUser, bool _Activo, bool _Default = false)
        {
            throw new NotImplementedException();
        }

        public void Delete(string _Parent, string Modulo, string _Designacao, string _User)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
     
    }
}
