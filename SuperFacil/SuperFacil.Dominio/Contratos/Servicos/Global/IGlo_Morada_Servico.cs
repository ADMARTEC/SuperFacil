using SuperFacil.Dominio.Modelos.Global;
using System;

namespace SuperFacil.Dominio.Contratos.Servicos.Global
{
    public interface IGlo_Morada_Servico : IDisposable
    {
        Glo_Morada GetID(string _Empresa, int value);
        Glo_Morada GetDesignacao(string _Empresa, string value);
        int GetPais(string _Designacao);
        int GetEmpresa(string _Empresa);
        int GetUsuario(string _Empresa, string _Usuario);

        void Create(string _Empresa, string _Designacao, string Pais, string _CreateUser, bool _Default = false);
        void Update(string _Empresa, string _Designacao, string Pais, string _UpdateUser, bool _Activo, int Morada_ID = 0, bool _Default = false);
        void Save(string _Empresa, string _Designacao, string Pais, string _User, bool _Activo, int Morada_ID = 0, bool _Default = false);
        void Delete(string _Empresa, string _Designacao, string DeleteUser);
    }
}
