using SuperFacil.Dominio.Modelos.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Sistema
{
    public interface ISis_Sessao_Servico: IDisposable
    {
        Sis_Sessao GetID(string _Empresa, int value);
        Sis_Sessao GetDispositivo(string _Empresa, string _Dispositivo);
        Sis_Sessao GetUser(string _Empresa, string _Usuario);

        int GetEmpresa(string _Empresa);
        int GetUsuario(string _Empresa, string value);

        void Create(string _Empresa, string _Dispositivo,DateTime Inicio, string _CreateUser, bool _Default = false);
        void Update(string _Empresa, string _Dispositivo, DateTime Inicio, DateTime? Fim, string _UpdateUser, bool _Activo, bool _Default = false);
        void Save(string _Empresa, string _Dispositivo, DateTime Inicio, DateTime? Fim, string _User, bool _Activo, bool _Default = false);
        void Delete(string _Empresa, string _Dispositivo, string _DeleteUser);

    }
}
