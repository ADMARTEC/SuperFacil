using SuperFacil.Dominio.Contratos.Repositorios.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Global;

namespace SuperFacil.Infraestrutura.Repositorio.Global
{
    public class Glo_Morada_Repositorio : IGlo_Morada_Repositorio
    {
        public void Create(Glo_Morada morada)
        {
            throw new NotImplementedException();
        }

        public void Deleted(Glo_Morada morada)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Glo_Morada> GetByClass(int _Empresa, int _Class_ID, string _ClasseNome)
        {
            throw new NotImplementedException();
        }

        public Task<Glo_Morada> GetByDesignacao(int _Empresa, string value)
        {
            throw new NotImplementedException();
        }

        public Task<Glo_Morada> GetByID(int _Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public Task<Glo_Morada> GetByPais(int _Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public void Update(Glo_Morada morada)
        {
            throw new NotImplementedException();
        }
    }
}
