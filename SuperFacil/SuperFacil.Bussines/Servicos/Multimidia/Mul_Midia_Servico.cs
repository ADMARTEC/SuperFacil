using SuperFacil.Dominio.Contratos.Servicos.Multimidia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Multimidia;
using SuperFacil.Dominio.Contratos.Repositorios.Multimidia;

namespace SuperFacil.Bussines.Servicos.Multimidia
    {
    public class Mul_Midia_Servico : IMul_Midia_Servico
        {

        private readonly IMul_Midia_Repositorio _repositorio;

        public Mul_Midia_Servico() { }

        public Mul_Midia_Servico(IMul_Midia_Repositorio repositorio)
            {
            _repositorio = repositorio;
            }
        public void Dispose()
            {
                {
                _repositorio.Dispose();
                GC.Collect();
                }
            }

        public int GetAutor(int Empresa, int value)
            {
            throw new NotImplementedException();
            }

        public Mul_Midia GetByDesignacao(int Empresa, string value)
            {
            throw new NotImplementedException();
            }

        public Mul_Midia GetByMidia_ID(int Empresa, int value)
            {
            throw new NotImplementedException();
            }

        public int GetLocalizacao(int Empresa, int value)
            {
            throw new NotImplementedException();
            }

        public void Registrar(Mul_Midia midia)
            {
            throw new NotImplementedException();
            }
        }
    }
