using SuperFacil.Common.Resource.Administracao;
using SuperFacil.Common.Validacao;
using SuperFacil.Dominio.Contratos.Repositorios.Administracao;
using SuperFacil.Dominio.Contratos.Servicos.Administracao;
using SuperFacil.Dominio.Modelos.Administracao;
using System;

namespace SuperFacil.Bussines.Servicos.Administracao
    {
    public class Adm_Usuario_Servico : IAdm_Usuario_Servico
        {
        private readonly IAdm_Usuario_Repositorio _repositorio;

        public Adm_Usuario_Servico() { }

        public Adm_Usuario_Servico(IAdm_Usuario_Repositorio repositorio)
            {
            _repositorio = repositorio;
            }

        public int GetEmpresa(string _Empresa)
            {
            return new Adm_Empresa_Servico().GetDesignacao(_Empresa).Empresa_ID;
            }

        public int GetPerfil(string _Empresa, string _Perfil)
            {
            return new Adm_Perfil_Servico().GetDesiginacao(_Empresa, _Perfil).Perfil_ID;
            }

        public int GetFuncionario(string _Funcionario)
            {
            throw new NotImplementedException();
            }

        public Adm_Usuario GetNome(string _Empresa, string value)
            {
            var result = _repositorio.GetByNome(GetEmpresa(_Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Adm_Usuario.TagUsuarioInvalido);

            return result;
            }

        public Adm_Usuario GetUsuario(string _Empresa, string value)
            {
            var result = _repositorio.GetByLogin(GetEmpresa(_Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Adm_Usuario.TagUsuarioInvalido);

            return result;
            }

        public Adm_Usuario GetAutenticacao(string _Empresa, string _usuario, string _senha)
            {
            var result = GetUsuario(_Empresa, _usuario);

            if (result.Senha != PasswordAssertionConcern.Encrypt(_senha))
                throw new Exception(Res_Adm_Usuario.TagCredencialInvalida);

            return result;
            }

        public string ResetSenha(string _Empresa, string _usuario)
            {
            var result = GetUsuario(_Empresa, _usuario);

            string NewSenha = result.Set_Reset_Senha();

            result.Auto_Validar();

            return NewSenha;
            }

        public void AlterarSenha(string _Empresa, string _usuario, string _senhaOld, string _senhaNew, string _senhaConfirm)
            {
            var result = GetAutenticacao(_Empresa, _usuario, _senhaOld);

            result.Set_Senha(_senhaNew, _senhaConfirm);

            result.Auto_Validar();

            _repositorio.Update(result);
            }

        public void Create(string _Empresa, string _Perfil, string _Funcionario, int? _Imagem, string _Usuario, string _Nome, string _Senha, string _Confirmar, DateTime _Data_Limite, string Create_User, bool _Default = false)
            {
            var Result = _repositorio.GetByLogin(GetEmpresa(_Empresa), _Usuario).Result;
            var _result = GetUsuario(_Empresa, Create_User);

            if (Result != null)
                throw new Exception(Res_Adm_Usuario.TagUsuarioDuplicado);

            var result = new Adm_Usuario(_Usuario, _Senha);


            result.Set_Usuario(GetEmpresa(_Empresa), GetPerfil(_Empresa, _Perfil), _Nome, _Usuario, _Data_Limite, GetFuncionario(_Funcionario));
            result.Set_Senha(_Senha, _Confirmar);
            result.Set_Cud_Create(_result.Usuario_ID, DateTime.Now, _Default);

            result.Auto_Validar();

            _repositorio.Create(result);

            }

        public void Update(string _Empresa, string _Perfil, string _Funcionario, int? _Imagem, string _Usuario, string _Nome, string _Senha, string _Confirmar, DateTime _Data_Limite, bool _Activo, string Update_User, bool _Default = false)
            {
            var result = GetUsuario(_Empresa, _Usuario);
            var _result = GetUsuario(_Empresa, Update_User);

            result.Set_Usuario(GetEmpresa(_Empresa), GetPerfil(_Empresa, _Perfil), _Nome, _Usuario, _Data_Limite, GetFuncionario(_Funcionario));
            result.Set_Senha(_Senha, _Confirmar);
            result.Set_Cud_Update(_Activo, _result.Usuario_ID, DateTime.Now, _Default);

            result.Auto_Validar();

            _repositorio.Update(result);

            }

        public void Save(string _Empresa, string _Perfil, string _Funcionario, int? _Imagem, string _Usuario, string _Nome, string _Senha, string _Confirmar, DateTime _Data_Limite, bool _Activo, string Create_User, bool _Default = false)
            {
            var result = GetUsuario(_Empresa, _Usuario);

            if (result != null)
                {
                Update(_Empresa, _Perfil, _Funcionario, _Imagem, _Usuario, _Nome, _Senha, _Confirmar, _Data_Limite, _Activo, Create_User, _Default);
                }
            else
                {
                Create(_Empresa, _Perfil, _Funcionario, _Imagem, _Usuario, _Nome, _Senha, _Confirmar, _Data_Limite, Create_User, _Default);
                }

            }

        public void Delete(string _Empresa, string _Usuario, string Deleted_User)
            {
            var result = GetUsuario(_Empresa, _Usuario);
            var _result = GetUsuario(_Empresa, Deleted_User);

            result.Set_Cud_Delete(_result.Usuario_ID, DateTime.Now);

            result.Auto_Validar();

            _repositorio.Delete(result);
            }

        public void Dispose()
            {
            _repositorio.Dispose();
            GC.Collect();
            }

        }
    }
