using SuperFacil.Dominio.Contratos.Servicos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Global;
using System.Drawing;
using System.Drawing.Imaging;
using SuperFacil.Infraestrutura.Repositorio.Global;

namespace SuperFacil.Bussines.Servicos.Global
{
    public class Glo_Imagem_Servico : IGlo_Imagem_Servico
    {

        private readonly Glo_Imagem_Repositorio _repositorio;

        public Glo_Imagem GetID(int value)
        {
            var result = _repositorio.GetByID(value).Result;

            if (result == null)
                throw new Exception();

            return result;
        }

        public Glo_Imagem GetDesignacao(string Empresa, Image _Imagem)
        {
            throw new NotImplementedException();
        }

        public Glo_Imagem GetDesignacao(string Empresa, string _Imagem)
        {
            throw new NotImplementedException();
        }

        public Glo_Imagem GetLastInsert(string Empresa)
        {
            throw new NotImplementedException();
        }

        public string ImageToString(Image imagem, ImageFormat formato)
        {
            throw new NotImplementedException();
        }

        public Image StringToImage(string value)
        {
            throw new NotImplementedException();
        }

        public void Create(string _Empresa, Image _Imagem, string _CreateUser, bool _Default)
        {
            throw new NotImplementedException();
        }

        public void Update(string _Empresa, Image _Imagem, string _UpdateUser, bool _Activo, bool _Default)
        {
            throw new NotImplementedException();
        }

        public void Save(string _Empresa, Image _Imagem, string _User, bool _Activo, bool _Default)
        {
            throw new NotImplementedException();
        }

        public void Delete(string _Empresa, Image _Imagem)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _repositorio.Dispose();
            GC.Collect();
        }
    }
}
