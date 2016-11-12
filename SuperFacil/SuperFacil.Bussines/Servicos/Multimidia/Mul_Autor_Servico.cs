using SuperFacil.Bussines.Servicos.Administracao;
using SuperFacil.Common.Resource.Multimidia;
using SuperFacil.Dominio.Contratos.Repositorios.Multimidia;
using SuperFacil.Dominio.Contratos.Servicos.Multimidia;
using SuperFacil.Dominio.Modelos.Multimidia;
using System;

namespace SuperFacil.Bussines.Servicos.Multimidia
{
    public class Mul_Autor_Servico : IMul_Autor_Servico
    {
        private readonly IMul_Autor_Repositorio _repositorio;

        public Mul_Autor_Servico() { }

        public Mul_Autor_Servico(IMul_Autor_Repositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public Mul_Autor GetID(string _Empresa, int value)
        {
            var result = _repositorio.GetByID(GetEmpresa(_Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Mul_Autor.TagInvalido);

            return result;
        }

        public Mul_Autor GetNome(string _Empresa, string value)
        {
            var result = _repositorio.GetByDesiginacao(GetEmpresa(_Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Mul_Autor.TagNomeInvalido);

            return result;
        }

        public Mul_Autor GetSobrenome(string _Empresa, string value)
        {
            var result = _repositorio.GetBySobrenome(GetEmpresa(_Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Mul_Autor.TagSobreNomeInvalido);

            return result;
        }

        public Mul_Autor GetAlcunha(string _Empresa, string value)
        {
            var result = _repositorio.GetByAlcunha(GetEmpresa(_Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Mul_Autor.TagAlcunhaInvalido);

            return result;
        }

        public Mul_Autor GetNomeSobrenome(string _Empresa, string _nome, string _sobrenome)
        {
            var result = _repositorio.GetByDesiginacao(GetEmpresa(_Empresa), _nome, _sobrenome).Result;

            if (result == null)
                throw new Exception(Res_Mul_Autor.TagSobreNomeInvalido);

            return result;
        }

        public Mul_Autor GetNomeSobrenomeAlcunha(string _Empresa, string _nome, string _sobrenome, string _alcunha)
        {
            var result = _repositorio.GetByDesiginacao(GetEmpresa(_Empresa), _nome, _sobrenome, _alcunha).Result;

            if (result == null)
                throw new Exception(Res_Mul_Autor.TagInvalido);

            return result;
        }

        public int GetBiografia(string _Biografia)
        {
            throw new NotImplementedException();
        }

        public int GetEmpresa(string _Empresa)
        {
            return new Adm_Empresa_Servico().GetDesignacao(_Empresa).Empresa_ID;
        }

        public int GetUsuario(string _Empresa, string _Usuario)
        {
            return new Adm_Usuario_Servico().GetUsuario(_Empresa, _Usuario).Usuario_ID;
        }

        public void Create(string _Empresa, int? _Biografia, string _Nome, string _CreateUser, bool _Default = false)
        {
            var result = _repositorio.GetByDesiginacao(GetEmpresa(_Empresa), _Nome).Result;

            if (result != null)
                throw new Exception(Res_Mul_Autor.TagDuplicado);

            result.Set_Autor(GetEmpresa(_Empresa), _Nome, _Biografia);
            result.Set_Cud_Create(GetUsuario(_Empresa, _CreateUser), DateTime.Now, _Default);

            _repositorio.Create(result);
        }

        public void Create(string _Empresa, int? _Biografia, string _Nome, string _Sobrenome, string _CreateUser, bool _Default = false)
        {
            var result = _repositorio.GetByDesiginacao(GetEmpresa(_Empresa), _Nome, _Sobrenome).Result;

            if (result != null)
                throw new Exception(Res_Mul_Autor.TagDuplicado);

            result.Set_Autor(GetEmpresa(_Empresa), _Nome, _Sobrenome, _Biografia);
            result.Set_Cud_Create(GetUsuario(_Empresa, _CreateUser), DateTime.Now, _Default);

            _repositorio.Create(result);
        }

        public void Create(string _Empresa, int? _Biografia, string _Nome, string _Sobrenome, string _Alcunha, string _CreateUser, bool _Default = false)
        {
            var result = _repositorio.GetByDesiginacao(GetEmpresa(_Empresa), _Nome, _Sobrenome, _Alcunha).Result;

            if (result != null)
                throw new Exception(Res_Mul_Autor.TagDuplicado);

            result.Set_Autor(GetEmpresa(_Empresa), _Nome, _Sobrenome, _Alcunha, _Biografia);
            result.Set_Cud_Create(GetUsuario(_Empresa, _CreateUser), DateTime.Now, _Default);

            _repositorio.Create(result);
        }

        public void Update(string _Empresa, int? _Biografia, string _Nome, string _UpdateUser, bool _Activo, bool _Default = false)
        {
            var result = GetNome(_Empresa, _Nome);

            result.Set_Autor(GetEmpresa(_Empresa), _Nome, _Biografia);
            result.Set_Cud_Update(_Activo, GetUsuario(_Empresa, _UpdateUser), DateTime.Now, _Default);

            _repositorio.Update(result);
        }

        public void Update(string _Empresa, int? _Biografia, string _Nome, string _Sobrenome, string _UpdateUser, bool _Activo, bool _Default = false)
        {
            var result = GetNomeSobrenome(_Empresa, _Nome, _Sobrenome);

            result.Set_Autor(GetEmpresa(_Empresa), _Nome, _Sobrenome, _Biografia);
            result.Set_Cud_Update(_Activo, GetUsuario(_Empresa, _UpdateUser), DateTime.Now, _Default);

            _repositorio.Update(result);
        }

        public void Update(string _Empresa, int? _Biografia, string _Nome, string _Sobrenome, string _Alcunha, string _UpdateUser, bool _Activo, bool _Default = false)
        {
            var result = GetNomeSobrenomeAlcunha(_Empresa, _Nome, _Sobrenome, _Alcunha);

            result.Set_Autor(GetEmpresa(_Empresa), _Nome, _Sobrenome, _Alcunha, _Biografia);
            result.Set_Cud_Update(_Activo, GetUsuario(_Empresa, _UpdateUser), DateTime.Now, _Default);

            _repositorio.Update(result);
        }

        public void Save(string _Empresa, int? _Biografia, string _Nome, string _User, bool _Activo, bool _Default = false)
        {
            var result = GetNome(_Empresa, _Nome);

            if (result != null)
            {
                Update(_Empresa, _Biografia, _Nome, _User, _Activo, _Default);
            }
            else
            {
                Create(_Empresa, _Biografia, _Nome, _User, _Default);
            }
        }

        public void Save(string _Empresa, int? _Biografia, string _Nome, string _Sobrenome, string _User, bool _Activo, bool _Default = false)
        {
            var result = GetNomeSobrenome(_Empresa, _Nome, _Sobrenome);

            if (result != null)
            {
                Update(_Empresa, _Biografia, _Nome, _Sobrenome, _User, _Activo, _Default);
            }
            else
            {
                Create(_Empresa, _Biografia, _Nome, _Sobrenome, _User, _Default);
            }
        }

        public void Save(string _Empresa, int? _Biografia, string _Nome, string _Sobrenome, string _Alcunha, string _User, bool _Activo, bool _Default = false)
        {
            var result = GetNomeSobrenomeAlcunha(_Empresa, _Nome, _Sobrenome, _Alcunha);

            if (result != null)
            {
                Update(_Empresa, _Biografia, _Nome, _Sobrenome, _Alcunha, _User, _Activo, _Default);
            }
            else
            {
                Create(_Empresa, _Biografia, _Nome, _Sobrenome, _Alcunha, _User, _Default);
            }
        }

        public void Delete(string _Empresa, string _Nome, string _DeleteUser)
        {
            var result = GetNome(_Empresa, _Nome);

            result.Set_Cud_Delete(GetUsuario(_Empresa, _DeleteUser), DateTime.Now);

            _repositorio.Deleted(result);
        }

        public void Delete(string _Empresa, string _Nome, string _Sobrenome, string _DeleteUser)
        {
            var result = GetNomeSobrenome(_Empresa, _Nome, _Sobrenome);

            result.Set_Cud_Delete(GetUsuario(_Empresa, _DeleteUser), DateTime.Now);

            _repositorio.Deleted(result);
        }

        public void Delete(string _Empresa, string _Nome, string _Sobrenome, string _Alcunha, string _DeleteUser)
        {
            var result = GetNomeSobrenomeAlcunha(_Empresa, _Nome, _Sobrenome, _Alcunha);

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
