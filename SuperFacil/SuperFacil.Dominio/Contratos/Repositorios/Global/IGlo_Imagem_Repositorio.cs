using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Repositorios.Global
{
    public interface IGlo_Imagem_Repositorio : IDisposable
    {
        Task<Glo_Imagem> GetByID(int value);
        Task<Glo_Imagem> GetByID(int Empresa, int value);
        Task<Glo_Imagem> GetByLastID(int Empresa);
        Task<Glo_Imagem> GetByDesignacao(int Empresa, string value);


        void Create(Glo_Imagem imagem);
        void Update(Glo_Imagem imagem);
        void Deleted(Glo_Imagem imagem);

    }
}
