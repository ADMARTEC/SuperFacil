using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Global
{
    public interface IGlo_Contacto_Servico : IDisposable
    {
        Glo_Contacto GetID(string _Empresa, int value);
        Glo_Contacto GetTelefone(string _Empresa, int? value);
        Glo_Contacto GetEmail(string _Empresa, string value);
        Glo_Contacto GetResponsavel(string _Empresa, string value);
        Glo_Contacto GetTeleEmail(string _Empresa,int _Telefone, string _Email);
        int GetEmpresa(string _Empresa);
        int GetUsuario(string _Empresa, string value);

        void Create(string _Empresa, int? Parent, int? _Telefone, string _Email, string _Responsavel, bool _Master, string _CreateUser, bool _Default);
        void Update(string _Empresa, int? Parent, int? _Telefone, string _Email, string _Responsavel, bool _Master, string _UpdateUser, bool _Activo, bool _Default);
        void Save(string _Empresa, int? Parent, int? _Telefone, string _Email, string _Responsavel, bool _Master, string _User, bool _Activo, bool _Default);
        void Delete(string _Empresa, int Contacto, string DeleteUser);
    }
}
