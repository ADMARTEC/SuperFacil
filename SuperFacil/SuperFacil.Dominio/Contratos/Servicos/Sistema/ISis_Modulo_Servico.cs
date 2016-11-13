using SuperFacil.Dominio.Modelos.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Sistema
{
    public interface ISis_Modulo_Servico : IDisposable
    {
        Sis_Modulo GetID(int value);
        Sis_Modulo GetDesignacao(string Parent, string value);
        int GetParent(string Parent);
        int GetUsuario(string _Empresa, string value);

        void Create(string _Parent, string _Desiginacao, string _CreateUser, bool _Default = false);
        void Update(string _Parent, string _Desiginacao, string _UpdateUser, bool _Activo, bool _Default = false);
        void Save(string _Parent, string _Desiginacao, string _UpdateUser, bool _Activo, bool _Default = false);
        void Delete(string _Parent, string _Desiginacao, string _DeleteUser);
    }
}
