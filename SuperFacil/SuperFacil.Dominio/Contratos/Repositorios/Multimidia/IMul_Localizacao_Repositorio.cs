using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Repositorios.Multimidia
    {
    public interface IMul_Localizacao_Repositorio : IDisposable
        {
        #region SELECT - R
        Task<Mul_Localizacao> GetByID(int Empresa, int value);
        #endregion

        #region CUD
        void Create(Mul_Localizacao localizacao);
        void Update(Mul_Localizacao localizacao);
        void Deleted(Mul_Localizacao localizacao);
        #endregion
        }
    }
