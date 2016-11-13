using SuperFacil.Dominio.Modelos.Multimidia;
using System;

namespace SuperFacil.Dominio.Contratos.Servicos.Multimidia
{
    public interface IMul_Biografia_Servico : IDisposable
    {
        Mul_Biografia GetID(string Empresa, int value);
        Mul_Biografia GetNota(string Empresa, string value);
        int GetEmpresa(string _Empresa);
        int GetUsuario(string _Empresa, string _Usuario);

        void Create(string _Empresa, string _Nota, string _CreateUser, bool _Default);
        void Update(string _Empresa, string _Nota, string _UpdateUser, bool _Activo, bool _Default);
        void Save(string _Empresa, string _Nota, string _User, bool _Activo, bool _Default);
        void Delete(string _Empresa, string _Nota);
        void Delete(string _Empresa, int _BiografiaID);
    }
}
