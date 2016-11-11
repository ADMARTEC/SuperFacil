using SuperFacil.Dominio.Contratos.Servicos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Dominio.Contratos.Repositorios.Global;
using SuperFacil.Common.Resource.Global;

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
            throw new NotImplementedException();
        }

        public Glo_Morada GetPais(string _Designacao)
        {
            throw new NotImplementedException();
        }

        public Glo_Morada GetDesignacao(string _Empresa, string value)
        {
            throw new NotImplementedException();
        }

        public int GetEmpresa(string _Empresa)
        {
            throw new NotImplementedException();
        }

        public int GetUsuario(string _Empresa, string _Usuario)
        {
            throw new NotImplementedException();
        }

        public void Create(string _Empresa, string _Designacao, string Pais, string _CreateUser, bool _Default = false)
        {
            throw new NotImplementedException();
        }

        public void Update(string _Empresa, string _Designacao, string Pais, string _UpdateUser, bool _Activo, int Morada_ID = 0, bool _Default = false)
        {
            if (Morada_ID <= 0)
                throw new Exception(Res_Glo_Morada.TagNotFoundOld);

            var result = GetID(_Empresa, Morada_ID);

            if (result == null)
                throw new Exception(Res_Glo_Morada.TagInvalida);

            

        }

        public void Save(string _Empresa, string _Designacao, string Pais, string _User, bool _Activo, int Morada_ID = 0, bool _Default = false)
        {
            if (Morada_ID > 0)
            {
                Update(_Empresa, _Designacao, Pais, _User, _Activo, Morada_ID, _Default);
            }
            else
            {
                Create(_Empresa, _Designacao, Pais, _User, _Default);
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
