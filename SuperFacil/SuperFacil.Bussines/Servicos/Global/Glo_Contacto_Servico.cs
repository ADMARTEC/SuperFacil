using SuperFacil.Dominio.Contratos.Servicos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Bussines.Servicos.Administracao;
using SuperFacil.Dominio.Contratos.Repositorios.Global;
using SuperFacil.Common.Resource.Global;

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
            throw new NotImplementedException();
        }

        public void Update(string _Empresa, int? Parent, int? _Telefone, string _Email, string _Responsavel, bool _Master, string _UpdateUser, bool _Activo, bool _Default)
        {
            var result = GetTelefone(_Empresa, _Telefone);
            throw new NotImplementedException();
        }

        public void Save(string _Empresa, int? Parent, int? _Telefone, string _Email, string _Responsavel, bool _Master, string _User, bool _Activo, bool _Default)
        {
            throw new NotImplementedException();
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
