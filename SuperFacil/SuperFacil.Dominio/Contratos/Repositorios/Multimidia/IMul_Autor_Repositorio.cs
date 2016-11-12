﻿using SuperFacil.Dominio.Modelos.Multimidia;
using System;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Repositorios.Multimidia
{
    public interface IMul_Autor_Repositorio : IDisposable
    {
        #region -Selecionar-
        Task<Mul_Autor> GetByID(int Empresa, int value);
        Task<Mul_Autor> GetByNome(int Empresa, string value);
        Task<Mul_Autor> GetBySobrenome(int Empresa, string value);
        Task<Mul_Autor> GetByAlcunha(int Empresa, string value);
        Task<Mul_Autor> GetByDesiginacao(int Empresa, string _Nome);
        Task<Mul_Autor> GetByDesiginacao(int Empresa, string _Nome, string _Sobrenome);
        Task<Mul_Autor> GetByDesiginacao(int Empresa, string _Nome, string _Sobrenome, string Alcunha);
        #endregion

        #region - Create, Update, Delete -
        void Create(Mul_Autor autor);
        void Update(Mul_Autor autor);
        void Deleted(Mul_Autor autor);
        #endregion
    }

}

