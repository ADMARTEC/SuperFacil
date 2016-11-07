using SuperFacil.Dominio.Contratos.Servicos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Dominio.Contratos.Repositorios.Global;
using SuperFacil.Dominio.Modelos.Administracao;
using SuperFacil.Common.Resource.Global;
using SuperFacil.Common.Resource.Administracao;
using SuperFacil.Bussines.Servicos.Administracao;

namespace SuperFacil.Bussines.Servicos.Global
{
    public class Glo_Pais_Servico : IGlo_Pais_Servico
    {
        private IGlo_Pais_Repositorio _repositorio;

        public Glo_Pais_Servico(IGlo_Pais_Repositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public Glo_Pais GetDesignacao(string value)
        {
            var result = _repositorio.GetByDesignacao(value).Result;

            if (result == null)
                throw new Exception(Res_Pais.TagPaisInvalido);

            return result;
        }

        public Glo_Pais GetRecursividade(int value)
        {
            return _repositorio.GetByParent(value).Result;
        }

        public int GetUsuario(string value, string _Empresa = null)
        {
            return new Adm_Usuario_Servico().GetUsuario(_Empresa, value).Usuario_ID;
        }

        public void Activacao(string _Pais, string _Usuario, bool _Activar)
        {
            int user = GetUsuario(_Usuario);

            var result = GetDesignacao(_Pais);

            result.Set_Cud_Update(_Activar, user, DateTime.Now);

            _repositorio.Update(result);
        }

        public void Create(int? _Parent, string _Designacao, string _Usuario, bool _Default = false)
        {
            int user = GetUsuario(_Usuario);

            var result = _repositorio.GetByDesignacao(_Designacao).Result;

            if (result != null)
                throw new Exception(Res_Pais.TagPaisDuplicado);

            result.Set_Pais(_Designacao, _Parent);
            result.Set_Cud_Create(user, DateTime.Now, _Default);

            _repositorio.Create(result);
        }

        public void Update(int? _Parent, string _Designacao, string _Usuario, bool _Activo, bool _Default = false)
        {
            var result = GetDesignacao(_Designacao);

            result.Set_Pais(_Designacao, _Parent);
            result.Set_Cud_Update(_Activo, GetUsuario(_Usuario), DateTime.Now, _Default);

            _repositorio.Update(result);
        }

        public void Save(int? _Parent, string _Designacao, string _Usuario, bool _Activo, bool _Default = false)
        {
            var result = GetDesignacao(_Designacao);

            if (result != null)
            {
                Update(_Parent, _Designacao, _Usuario, _Activo, _Default);
            }
            else
            {
                Create(_Parent, _Designacao, _Usuario, _Default);
            }
        }

        public void Delete(string _Pais, string _Usuario)
        {
            int user = GetUsuario(_Usuario);

            var result = GetDesignacao(_Pais);

            result.Set_Cud_Delete(user, DateTime.Now);

            _repositorio.Deleted(result);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
            GC.Collect();
        }


    }
}
