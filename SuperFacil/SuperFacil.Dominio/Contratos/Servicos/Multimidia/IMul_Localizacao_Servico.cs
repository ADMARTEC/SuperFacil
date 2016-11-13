using SuperFacil.Dominio.Modelos.Multimidia;
using System;

namespace SuperFacil.Dominio.Contratos.Servicos.Multimidia
{
    public interface IMul_Localizacao_Servico : IDisposable
    {
        Mul_Localizacao GetID(string _Empresa, int value);
        Mul_Localizacao GetDesignacao(string _Empresa, string value);
        int GetParent(string _Empresa, string value);
        int GetEmpresa(string _Empresa);
        int GetUsuario(string _Empresa, string value);

        void Create(string _Empresa, string _Parent, string _Designacao, string _CreateUser, bool _Default);
        void Update(string _Empresa, string _Parent, string _Designacao, string _UpdateUser, bool _Activo, bool _Default);
        void Save(string _Empresa, string _Parent, string _Designacao, string _UpdateUser, bool _Activo, bool _Default);
        void Delete(string _Empresa, string _Parent, string _Designacao, string _DeleteUser);
    }
}
