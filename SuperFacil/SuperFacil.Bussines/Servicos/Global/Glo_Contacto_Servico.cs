using SuperFacil.Bussines.Servicos.Administracao;
using SuperFacil.Common.Resource.Global;
using SuperFacil.Dominio.Contratos.Repositorios.Global;
using SuperFacil.Dominio.Contratos.Servicos.Global;
using SuperFacil.Dominio.Modelos.Global;
using System;

namespace SuperFacil.Bussines.Servicos.Global
{
    public class Glo_Contacto_Servico : IGlo_Contacto_Servico
    {
        private readonly IGlo_Contacto_Repositorio _repositorio;

        public Glo_Contacto_Servico(IGlo_Contacto_Repositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public Glo_Contacto GetID(string _Empresa, int value)
        {
            var result = _repositorio.GetByID(GetEmpresa(_Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Glo_Contacto.TagInvalido);

            return result;
        }

        public Glo_Contacto GetResponsavel(string _Empresa, string value)
        {
            var result = _repositorio.GetByResponsavel(GetEmpresa(_Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Glo_Contacto.TagInvalido);

            return result;
        }

        public Glo_Contacto GetTelefone(string _Empresa, int? value)
        {
            var result = _repositorio.GetByTelefone(GetEmpresa(_Empresa), value.Value).Result;

            if (result == null)
                throw new Exception(Res_Glo_Contacto.TagInvalido);

            return result;
        }

        public Glo_Contacto GetEmail(string _Empresa, string value)
        {
            var result = _repositorio.GetByEmail(GetEmpresa(_Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Glo_Contacto.TagInvalido);

            return result;
        }

        public Glo_Contacto GetTeleEmail(string _Empresa, int _Telefone, string _Email)
        {
            var result = _repositorio.GetByTelefoneEmail(GetEmpresa(_Empresa), _Telefone, _Email).Result;

            if (result == null)
                throw new Exception(Res_Glo_Contacto.TagNotFound);

            return result;
        }

        public int GetEmpresa(string _Empresa)
        {
            return new Adm_Empresa_Servico().GetDesignacao(_Empresa).Empresa_ID;
        }

        public int GetUsuario(string _Empresa, string value)
        {
            return new Adm_Usuario_Servico().GetUsuario(_Empresa, value).Usuario_ID;
        }

        public void Create(string _Empresa, int? Parent, int? _Telefone, string _Email, string _Responsavel, bool _Master, string _CreateUser, bool _Default)
        {
            var result = _repositorio.GetByTelefoneEmail(GetEmpresa(_Empresa), _Telefone.Value, _Email).Result;

            if (result != null)
                throw new Exception(Res_Glo_Contacto.TagDuplicado);

            result.Set_Contacto(GetEmpresa(_Empresa), Parent, _Telefone, _Email, _Responsavel, _Master);
            result.Set_Cud_Create(GetUsuario(_Empresa, _CreateUser), DateTime.Now, _Default);

            _repositorio.Create(result);
        }

        public void Update(string _Empresa, int? Parent, int? _Telefone, string _Email, string _Responsavel, bool _Master, string _UpdateUser, bool _Activo, bool _Default)
        {
            var result = GetTeleEmail(_Empresa, _Telefone.Value, _Email);

            result.Set_Contacto(GetEmpresa(_Empresa), Parent, _Telefone, _Email, _Responsavel, _Master);
            result.Set_Cud_Update(_Activo, GetUsuario(_Empresa, _UpdateUser), DateTime.Now);

            _repositorio.Update(result);
        }

        public void Save(string _Empresa, int? Parent, int? _Telefone, string _Email, string _Responsavel, bool _Master, string _User, bool _Activo, bool _Default)
        {
            var result = GetTeleEmail(_Empresa, _Telefone.Value, _Email);

            if (result != null)
            {
                Update(_Empresa, Parent, _Telefone, _Email, _Responsavel, _Master, _User, _Activo, _Default);
            }
            else
            {
                Create(_Empresa, Parent, _Telefone, _Email, _Responsavel, _Master, _User, _Default);
            }
        }

        public void Delete(string _Empresa, int Contacto, string DeleteUser)
        {
            var result = GetID(_Empresa, Contacto);
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
