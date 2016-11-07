using SuperFacil.Common.Resource.Administracao;
using SuperFacil.Dominio.Contratos.Repositorios.Administracao;
using SuperFacil.Dominio.Contratos.Servicos.Administracao;
using SuperFacil.Dominio.Modelos.Administracao;
using System;

namespace SuperFacil.Bussines.Servicos.Administracao
{
    public class Adm_Perfil_Servico : IAdm_Perfil_Servico
    {
        private readonly IAdm_Perfil_Repositorio _repositorio;

        public Adm_Perfil_Servico() { }

        public Adm_Perfil_Servico(IAdm_Perfil_Repositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public Adm_Perfil GetID(int Empresa, int value)
        {
            var result = _repositorio.GetByID(Empresa, value).Result;

            if (result == null)
                throw new Exception(Res_Adm_Perfil.TagInvalido);

            return result;
        }

        public Adm_Perfil GetDesiginacao(string Empresa, string value)
        {
            var result = _repositorio.GetByDesiginacao(GetEmpresa(Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Adm_Perfil.TagInvalido);

            return result;
        }

        public Adm_Perfil GetRecursividade(string Empresa, int value)
        {
            var result = _repositorio.GetByParent(GetEmpresa(Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Adm_Perfil.TagParentInvlido);

            return result;
        }

        public int GetEmpresa(string _Empresa)
        {
            return new Adm_Empresa_Servico().GetDesignacao(_Empresa).Empresa_ID;
        }

        public int GetUsuario(string _Empresa, string _Usuario)
        {
            return new Adm_Usuario_Servico().GetUsuario(_Empresa, _Usuario).Usuario_ID;
        }

        public void Create(string _Empresa, int? _Parent, string _Designacao, int? _HorarioAcesso, string CreateUser, bool _Default)
        {
            var Result = _repositorio.GetByDesiginacao(GetEmpresa(_Empresa), _Designacao);

            if (Result != null)
                throw new Exception(Res_Adm_Perfil.TagDuplicado);

            var result = new Adm_Perfil();

            result.Set_Perfil(GetEmpresa(_Empresa), _HorarioAcesso, _Designacao, _Parent);
            result.Set_Cud_Create(GetUsuario(_Empresa, CreateUser), DateTime.Now, _Default);

            _repositorio.Create(result);
        }

        public void Update(string _Empresa, int? _Parent, string _Designacao, int? _HorarioAcesso, string UpdateUser, bool _Activo, bool _Default)
        {
            var result = GetDesiginacao(_Empresa, _Designacao);

            result.Set_Perfil(GetEmpresa(_Empresa), _HorarioAcesso, _Designacao, _Parent);
            result.Set_Cud_Update(_Activo, GetUsuario(_Empresa, UpdateUser), DateTime.Now, _Default);

            _repositorio.Update(result);
        }

        public void Save(string _Empresa, int? _Parent, string _Designacao, int? _HorarioAcesso, string User, bool _Activo, bool _Default)
        {
            var result = GetDesiginacao(_Empresa, _Designacao);

            if (result != null)
            {
                Update(_Empresa, _Parent, _Designacao, _HorarioAcesso, User, _Activo, _Default);
            }
            else
            {
                Create(_Empresa, _Parent, _Designacao, _HorarioAcesso, User, _Default);
            }
        }

        public void Delete(string _Empresa, string _Perfil, string _DeleteUser)
        {
            var result = GetDesiginacao(_Empresa, _Perfil);

            result.Set_Cud_Delete(GetUsuario(_Empresa, _DeleteUser), DateTime.Now);

            _repositorio.Deleted(result);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
            GC.Collect();
        }
    }
}
