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

        public int GetUsuario(string value)
        {
            // Esta função deve ser completa com a conclusao do usuario.
            var user = new Adm_Usuario();

            if (user == null)
                throw new Exception(Res_Adm_Usuario.TagUsuarioInvalido);

            return user.Usuario_ID;
        }

        public void Create(int? _Parent, string _Designacao, string _Usuario, bool _Default = false)
        {
            int user = GetUsuario(_Usuario);

            var result = _repositorio.GetByDesignacao(_Designacao).Result;

            if (result != null)
                throw new Exception(Res_Pais.TagPaisDuplicado);

            result.Set_Pais(_Designacao, _Parent);
            result.Set_Cud(user, DateTime.Now, _Default);

            _repositorio.Create(result);
        }

        public void Update(int? _Parent, string _Designacao, string _Usuario, bool _Default = false)
        {
            int user = GetUsuario(_Usuario);

            var result = GetDesignacao(_Designacao);

            result.Set_Pais(_Designacao, _Parent);
            result.Set_Cud(user, DateTime.Now);

            _repositorio.Update(result);
        }

        public void Activacao(string _Pais, string _Usuario, bool _Activar)
        {
            int user = GetUsuario(_Usuario);

            var result = GetDesignacao(_Pais);

            result.Set_Cud(_Activar, user, DateTime.Now,false);

            _repositorio.Update(result);
        }

        public void Eliminado(string _Pais, string _Usuario)
        {
            int user = GetUsuario(_Usuario);

            var result = GetDesignacao(_Pais);

            result.Set_Cud(user, DateTime.Now);

            _repositorio.Deleted(result);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
            GC.Collect();
        }

        /// <summary>
        /// Criar ou actualizar dados do pais
        /// </summary>
        /// <param name="_Parent"></param>
        /// <param name="_Designacao"></param>
        /// <param name="_Usuario"></param>      
        /// <param name="_Default"></param>
        public void Guardar(int? _Parent, string _Designacao, string _Usuario, bool _Default = false)
        {
            var result = GetDesignacao(_Designacao);

            if (result.Pais_ID > 0)
            {
                Update(_Parent, _Designacao, _Usuario, _Default);
            }
            else
            {
                Create(_Parent, _Designacao, _Usuario, _Default);
            }
        }

    
    }
}
