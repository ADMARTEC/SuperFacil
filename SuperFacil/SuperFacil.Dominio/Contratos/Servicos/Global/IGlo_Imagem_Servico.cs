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
        Task<Glo_Imagem> GetID(int value);
        Task<Image> GetLastInsert(int Empresa);
        Task<string> ImageToString(Image imagem, ImageFormat formato);
        Task<Image> StringToImage(string value);        

        void Guardar(Glo_Imagem imagem);
        void Eliminar(Glo_Imagem imagem);                
    }
}
