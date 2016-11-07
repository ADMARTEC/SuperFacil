using SuperFacil.Dominio.Modelos.Administracao;
using System;

namespace SuperFacil.Dominio.Contratos.Servicos.Administracao
{
    public interface IAdm_Usuario_Servico : IDisposable
    {
        Adm_Usuario GetAutenticacao(string _Empresa, string _usuario, string _senha);
        Adm_Usuario GetNome(string _Empresa, string value);
        Adm_Usuario GetUsuario(string _Empresa, string value);
        int GetEmpresa(string _Empresa);
        int GetPerfil(string _Empresa, string _Perfil);
        int GetFuncionario(string _Funcionario);
        string ResetSenha(string _Empresa, string _usuario);

        void AlterarSenha(string _Empresa, string _usuario, string _senhaOld, string _senhaNew, string _senhaConfirm);
        void Create(string _Empresa, string _Perfil, string _Funcionario, int? _Imagem, string _Usuario, string _Nome, string _Senha, string _Confirmar, DateTime _Data_Limite, string Create_User, bool _Default = false);
        void Update(string _Empresa, string _Perfil, string _Funcionario, int? _Imagem, string _Usuario, string _Nome, string _Senha, string _Confirmar, DateTime _Data_Limite, bool _Activo, string Update_User, bool _Default = false);
        void Save(string _Empresa, string _Perfil, string _Funcionario, int? _Imagem, string _Usuario, string _Nome, string _Senha, string _Confirmar, DateTime _Data_Limite, bool _Activo, string Create_User, bool _Default = false);
        void Delete(string _Empresa, string _Usuario, string Deleted_User);
    }
}
