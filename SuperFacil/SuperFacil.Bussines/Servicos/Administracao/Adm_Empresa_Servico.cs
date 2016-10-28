using SuperFacil.Dominio.Contratos.Servicos.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Administracao;
using SuperFacil.Dominio.Contratos.Repositorios.Administracao;

namespace SuperFacil.Bussines.Servicos.Administracao
{
    public class Adm_Empresa_Servico : IAdm_Empresa_Servico
    {
        private IAdm_Empresa_Repositorio _repositorio;

        public Adm_Empresa_Servico(IAdm_Empresa_Repositorio repositorio)
        {
            _repositorio = repositorio;
        }


        public Adm_Empresa GetDesignacao(string _designacao)
        {              
            return _repositorio.GetByDesignaca(_designacao).Result;
        }

        public Adm_Empresa GetDesignacao(string _designacao, string _pais)
        {
            throw new NotImplementedException();
        }

        public Adm_Empresa GetDesignacao(string _designacao, string _pais, string _morada)
        {
            throw new NotImplementedException();
        }

        public Adm_Empresa GetDesigncao(string _designacao, string _nif)
        {
            throw new NotImplementedException();
        }

        public Adm_Empresa GetDesigncao(string _designacao, string _nif, int _telefone)
        {
            throw new NotImplementedException();
        }

        public Adm_Empresa GetRecursive(string _designacao)
        {
            throw new NotImplementedException();
        }

        public Adm_Empresa GetRecursive(int value)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Adm_Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Adm_Empresa empresa)
        {
            throw new NotImplementedException();
        }
    }
}
