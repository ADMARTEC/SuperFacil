using SuperFacil.Dominio.Contratos.Servicos.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Sistema;

namespace SuperFacil.Bussines.Servicos.Sistema
{
    public class Sis_Sessao_Servico : ISis_Sessao_Servico
    {
        public Sis_Sessao GetID(string _Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public Sis_Sessao GetDispositivo(string _Empresa, string _Dispositivo)
        {
            throw new NotImplementedException();
        }

        public Sis_Sessao GetUser(string _Empresa, string _Usuario)
        {
            throw new NotImplementedException();
        }

        public int GetEmpresa(string _Empresa)
        {
            throw new NotImplementedException();
        }              

        public int GetUsuario(string _Empresa, string value)
        {
            throw new NotImplementedException();
        }

        public void Create(string _Empresa, string _Dispositivo, DateTime Inicio, string _CreateUser, bool _Default = false)
        {
            throw new NotImplementedException();
        }

        public void Update(string _Empresa, string _Dispositivo, DateTime Inicio, DateTime? Fim, string _UpdateUser, bool _Activo, bool _Default = false)
        {
            throw new NotImplementedException();
        }

        public void Save(string _Empresa, string _Dispositivo, DateTime Inicio, DateTime? Fim, string _User, bool _Activo, bool _Default = false)
        {
            throw new NotImplementedException();
        }

        public void Delete(string _Empresa, string _Dispositivo, string _DeleteUser)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
     
    }
}
