using SuperFacil.Bussines.Servicos.Administracao;
using SuperFacil.Common.Resource.Global;
using SuperFacil.Dominio.Contratos.Servicos.Global;
using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Infraestrutura.Repositorio.Global;
using System;
using System.Drawing;
using System.IO;

namespace SuperFacil.Bussines.Servicos.Global
{
    public class Glo_Imagem_Servico : IGlo_Imagem_Servico
    {
        private readonly Glo_Imagem_Repositorio _repositorio;

        public Glo_Imagem GetID(int value)
        {
            var result = _repositorio.GetByID(value).Result;

            if (result == null)
                throw new Exception(Res_Glo_Imagem.TagNotFound);

            return result;
        }

        public Glo_Imagem GetLastInsert(string Empresa)
        {
            var result = _repositorio.GetByLastID(GetEmpresa(Empresa)).Result;

            if (result == null)
                throw new Exception(Res_Glo_Imagem.TagNotFound);

            return result;
        }

        public int GetUsuario(string _Empresa, string value)
        {
            return new Adm_Usuario_Servico().GetUsuario(_Empresa, value).Usuario_ID;
        }

        public int GetEmpresa(string _Empresa)
        {
            return new Adm_Empresa_Servico().GetDesignacao(_Empresa).Empresa_ID;
        }

        public string ImagemToString(string _ImagemPath)
        {
            return Convert.ToBase64String(File.ReadAllBytes(@"" + _ImagemPath + ""));
        }

        public Image StringToImagem(string _Imagem)
        {
            return Image.FromStream(new MemoryStream(Convert.FromBase64String(_Imagem)));
        }

        public void Create(string _Empresa, string _ImagemPath, string _CreateUser, bool _Default = false)
        {
            var result = new Glo_Imagem();
            result.Set_Imagem(GetEmpresa(_Empresa), ImagemToString(_ImagemPath));
            result.Set_Cud_Create(GetUsuario(_Empresa, _CreateUser), DateTime.Now, _Default);

            _repositorio.Create(result);
        }

        public void Update(string _Empresa, int Imagem_ID, string _ImagemPath, string _UpdateUser, bool _Activo, bool _Default = false)
        {
            var result = GetID(Imagem_ID);

            result.Set_Imagem(GetEmpresa(_Empresa), ImagemToString(_ImagemPath));
            result.Set_Cud_Update(_Activo, GetUsuario(_Empresa, _UpdateUser), DateTime.Now);

            _repositorio.Update(result);
        }

        public void Save(string _Empresa, string _ImagemPath, string _User, bool _Activo, int? Imagem_ID = null, bool _Default = false)
        {
            if (Imagem_ID != null)
            {
                Update(_Empresa, Imagem_ID.Value, _ImagemPath, _User, _Activo, _Default);
            }
            else
            {
                Create(_Empresa, _ImagemPath, _User, _Default);
            }
        }

        public void Delete(string _Empresa, int value, string _DeleteUser)
        {
            var result = GetID(value);

            if (result == null)
                throw new Exception(Res_Glo_Imagem.TagInvalido);

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
