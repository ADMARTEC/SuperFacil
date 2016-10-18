using SuperFacil.Dominio.Contratos.Repositorios.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Global;

namespace SuperFacil.Infraestrutura.Repositorio.Global
{
    public class Glo_Contacto_Repositorio : IGlo_Contacto_Repositorio
    {
        public void Create(Glo_Contacto contacto)
        {
            throw new NotImplementedException();
        }

        public void Deleted(Glo_Contacto contacto)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Glo_Contacto> GetByClass(int _Empresa, int _Class_ID, string _ClasseNome)
        {
            throw new NotImplementedException();
        }

        public Task<Glo_Contacto> GetByID(int _Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public Task<Glo_Contacto> GetByTelefone(int _Empresa, int value)
        {
            throw new NotImplementedException();
        }

        public void Update(Glo_Contacto contacto)
        {
            throw new NotImplementedException();
        }
    }
}
