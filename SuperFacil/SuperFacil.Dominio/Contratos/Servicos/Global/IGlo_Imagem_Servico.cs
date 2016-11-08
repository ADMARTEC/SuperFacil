using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace SuperFacil.Dominio.Contratos.Servicos.Global
{
    public interface IGlo_Imagem_Servico : IDisposable
    {
        Glo_Imagem GetID(int value);
        Glo_Imagem GetLastInsert(string Empresa);
        Glo_Imagem GetDesignacao(string Empresa, string _Imagem);
        Glo_Imagem GetDesignacao(string Empresa, Image _Imagem);

        string ImageToString(Image imagem, ImageFormat formato);
        Image StringToImage(string value);

        void Create(string _Empresa, Image _Imagem, string _CreateUser, bool _Default);
        void Update(string _Empresa, Image _Imagem, string _UpdateUser, bool _Activo, bool _Default);
        void Save(string _Empresa, Image _Imagem, string _User, bool _Activo, bool _Default);
        void Delete(string _Empresa, Image _Imagem);                
    }
}
