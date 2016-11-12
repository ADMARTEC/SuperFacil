using SuperFacil.Bussines.Servicos.Administracao;
using SuperFacil.Common.Resource.Global;
using SuperFacil.Dominio.Contratos.Repositorios.Global;
using SuperFacil.Dominio.Contratos.Servicos.Global;
using SuperFacil.Dominio.Modelos.Global;
using System;

namespace SuperFacil.Bussines.Servicos.Global
{
    public class Glo_Morada_Servico : IGlo_Morada_Servico
    {
        private readonly IGlo_Morada_Repositorio _repositorio;

        public Glo_Morada_Servico(IGlo_Morada_Repositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public Glo_Morada GetID(string _Empresa, int value)
        {
            var result = GetID(_Empresa, value);

            if (result == null)
                throw new Exception(Res_Glo_Morada.TagInvalida);

            return result;
        }

        public int GetPais(string _Designacao)
        {
            return new Glo_Pais_Servico().GetDesignacao(_Designacao).Pais_ID;
        }

        public Glo_Morada GetDesignacao(string _Empresa, string value)
        {
            var result = _repositorio.GetByDesignacao(GetEmpresa(_Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Glo_Morada.TagInvalida);

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

        public void Create(string _Empresa, string _Designacao, string _Pais, string _CreateUser, bool _Default = false)
        {
            var result = _repositorio.GetByDesignacao(GetEmpresa(_Empresa), _Designacao).Result;

            if (result != null)
                throw new Exception(Res_Glo_Morada.TagDuplicado);

            result.Set_Morada(GetEmpresa(_Empresa), GetPais(_Pais), _Designacao);
            result.Set_Cud_Create(GetUsuario(_Empresa, _CreateUser), DateTime.Now, _Default);

            _repositorio.Create(result);
        }

        public void Update(string _Empresa, string _Designacao, string _Pais, string _UpdateUser, bool _Activo, int Morada_ID = 0, bool _Default = false)
        {
            if (Morada_ID <= 0)
                throw new Exception(Res_Glo_Morada.TagNotFoundOld);

            var result = GetID(_Empresa, Morada_ID);

            result.Set_Morada(GetEmpresa(_Empresa), GetPais(_Pais), _Designacao);
            result.Set_Cud_Update(_Activo, GetUsuario(_Empresa, _UpdateUser), DateTime.Now, _Default);

            _repositorio.Update(result);
        }

        public void Save(string _Empresa, string _Designacao, string _Pais, string _User, bool _Activo, int Morada_ID = 0, bool _Default = false)
        {
            if (Morada_ID > 0)
            {
                Update(_Empresa, _Designacao, _Pais, _User, _Activo, Morada_ID, _Default);
            }
            else
            {
                Create(_Empresa, _Designacao, _Pais, _User, _Default);
            }
        }

        public void Delete(string _Empresa, string _Designacao, string DeleteUser)
        {
            var result = GetDesignacao(_Empresa, _Designacao);
            result.Set_Cud_Delete(GetUsuario(_Empresa, DeleteUser), DateTime.Now);

            _repositorio.Deleted(result);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
            GC.Collect();
        }
    }
}
