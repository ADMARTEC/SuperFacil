using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Repositorios.Multimidia
    {
    public interface IMul_Autor_Repositorio : IDisposable
        {
        #region SELECT - R
        Task<Mul_Autor> GetByID(int Empresa, int value);
        Task<Mul_Autor> GetByDesiginacao(int Empresa, string value);
        #endregion

        #region CUD
        void Create(Mul_Autor autor);
        void Update(Mul_Autor autor);
        void Deleted(Mul_Autor autor);
        #endregion
        }

    }

