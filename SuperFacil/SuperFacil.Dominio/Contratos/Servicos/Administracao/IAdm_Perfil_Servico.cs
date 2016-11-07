using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Administracao
{
    public interface IAdm_Perfil_Servico : IDisposable
    {
        Adm_Perfil GetID(int Empresa, int value);
        Adm_Perfil GetDesiginacao(string Empresa, string value);
        Adm_Perfil GetRecursividade(string Empresa, int value);
        int GetEmpresa(string _Empresa);
        int GetUsuario(string _Empresa, string _Usuario);


        void Create(string _Empresa, int? _Parent, string _Designacao, int? _HorarioAcesso, string CreateUser, bool _Default);
        void Update(string _Empresa, int? _Parent, string _Designacao, int? _HorarioAcesso, string UpdateUser, bool _Activo, bool _Default);
        void Save(string _Empresa, int? _Parent, string _Designacao, int? _HorarioAcesso, string User, bool _Activo, bool _Default);
        void Delete(string _Empresa, string _Perfil, string _DeleteUser);
    }
}
