using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Multimidia
{
    public interface IMul_Autor_Servico : IDisposable
    {
        Mul_Autor GetID(string _Empresa, int value);
        Mul_Autor GetNome(string _Empresa, string value);
        Mul_Autor GetSobrenome(string _Empresa, string value);
        Mul_Autor GetAlcunha(string _Empresa, string value);      
        Mul_Autor GetNomeSobrenome(string _Empresa, string _nome, string _sobrenome);
        Mul_Autor GetNomeSobrenomeAlcunha(string _Empresa, string _nome, string _sobrenome, string _alcunha);

        int GetEmpresa(string _Empresa);
        int GetBiografia(string _Biografia);
        int GetUsuario(string _Empresa, string _Usuario);

        void Create(string _Empresa, int? _Biografia, string _Nome, string _CreateUser, bool _Default = false);
        void Create(string _Empresa, int? _Biografia, string _Nome, string _Sobrenome, string _CreateUser, bool _Default = false);
        void Create(string _Empresa, int? _Biografia, string _Nome, string _Sobrenome, string _Alcunha, string _CreateUser, bool _Default = false);

        void Update(string _Empresa, int? _Biografia, string _Nome, string _UpdateUser, bool _Activo, bool _Default = false);
        void Update(string _Empresa, int? _Biografia, string _Nome, string _Sobrenome, string _UpdateUser, bool _Activo, bool _Default = false);
        void Update(string _Empresa, int? _Biografia, string _Nome, string _Sobrenome, string _Alcunha, string _UpdateUser, bool _Activo, bool _Default = false);

        void Save(string _Empresa, int? _Biografia, string _Nome, string _User, bool _Activo, bool _Default = false);
        void Save(string _Empresa, int? _Biografia, string _Nome, string _Sobrenome, string _User, bool _Activo, bool _Default = false);
        void Save(string _Empresa, int? _Biografia, string _Nome, string _Sobrenome,string _Alcunha, string _User, bool _Activo, bool _Default = false);

        void Delete(string _Empresa, string _Nome, string _DeleteUser);
        void Delete(string _Empresa, string _Nome, string _Sobrenome, string _DeleteUser);
        void Delete(string _Empresa, string _Nome, string _Sobrenome, string _Alcunha, string _DeleteUser);

    }
}
