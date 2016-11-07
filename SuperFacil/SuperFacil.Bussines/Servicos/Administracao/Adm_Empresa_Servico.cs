using SuperFacil.Common.Resource;
using SuperFacil.Common.Resource.Administracao;
using SuperFacil.Dominio.Contratos.Repositorios.Administracao;
using SuperFacil.Dominio.Contratos.Servicos.Administracao;
using SuperFacil.Dominio.Modelos.Administracao;
using System;

namespace SuperFacil.Bussines.Servicos.Administracao
{
    public class Adm_Empresa_Servico : IAdm_Empresa_Servico
    {
        private IAdm_Empresa_Repositorio _repositorio;

        public Adm_Empresa_Servico() { }

        public Adm_Empresa_Servico(IAdm_Empresa_Repositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public Adm_Empresa GetDesignacao(string _designacao)
        {
            var result = _repositorio.GetByDesignaca(_designacao).Result;

            if (result == null)
                throw new Exception(Res_Adm_Empresa.TagInvalida);

            return result;
        }

        public Adm_Empresa GetDesignacao(string _designacao, string _nif)
        {
            var result = GetDesignacao(_designacao);

            if (result.NIF != _nif)
                throw new Exception(Res_Base.TagNIFNotFound);

            return result;
        }

        public Adm_Empresa GetRecursive(string _designacao)
        {
            throw new NotImplementedException();
        }

        public Adm_Empresa GetRecursive(int value)
        {
            throw new NotImplementedException();
        }

        public int GetUsuario( string _Designacao, string _Empresa = null)
        {
            var result = new Adm_Usuario_Servico().GetUsuario(_Empresa, _Designacao);

            return result.Usuario_ID;
        }

        public void Create(int? _Parent, string _Designacao, string _NIF, int _Contacto, int _Pais, int _Morada, int? _Imagem, string _CreateUser, bool _Default)
        {
            var result = _repositorio.GetByDesignaca(_Designacao).Result;

            if (result != null)
                throw new Exception(Res_Adm_Empresa.TagDuplicado);

            result.Set_Empresa(_Parent, _Designacao, _NIF, _Contacto, _Pais, _Morada, _Imagem);
            result.Set_Cud_Create(GetUsuario(_CreateUser), DateTime.Now, _Default);

            _repositorio.Create(result);
        }

        public void Update(int? _Parent, string _Designacao, string _NIF, int _Contacto, int _Pais, int _Morada, int? _Imagem, string _UpdateUser, bool _Activo, bool _Default)
        {
            var result = GetDesignacao(_Designacao);

            if (result == null)
                throw new Exception(Res_Adm_Empresa.TagInvalida);

            result.Set_Empresa(_Parent, _Designacao, _NIF, _Contacto, _Pais, _Morada, _Imagem);
            result.Set_Cud_Update(_Activo, GetUsuario(_UpdateUser,_Designacao), DateTime.Now, _Default);

            _repositorio.Update(result);
        }

        public void Save(int? _Parent, string _Designacao, string _NIF, int _Contacto, int _Pais, int _Morada, int? _Imagem, string _Usuario, bool _Activo, bool _Default)
        {
            var result = GetDesignacao(_Designacao);

            if (result != null)
            {
                Update(_Parent, _Designacao, _NIF, _Contacto, _Pais, _Morada, _Imagem, _Usuario, _Activo, _Default);
            }
            else
            {
                Create(_Parent, _Designacao, _NIF, _Contacto, _Pais, _Morada, _Imagem, _Usuario, _Default);
            }
        }

        public void Delete(string _Designacao, string _DeleteUser)
        {
            var result = GetDesignacao(_Designacao);

            result.Set_Cud_Delete(GetUsuario(_DeleteUser,_Designacao), DateTime.Now);

            _repositorio.Deleted(result);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
            GC.Collect();
        }


    }
}
