using SuperFacil.Dominio.Contratos.Repositorios.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Global;
using System.Data.Entity;

namespace SuperFacil.Infraestrutura.Repositorio.Global
{
    public class Glo_Contacto_Repositorio : IGlo_Contacto_Repositorio
    {
        private SuperFacilContexto db;

        public Glo_Contacto_Repositorio(SuperFacilContexto _db)
        {
            db = _db;
        }

        public Task<Glo_Contacto> GetByID(int _Empresa, int value)
        {
            return db.Glo_Contacto.Where(x => x.Empresa_ID == _Empresa && x.Contacto_ID == value).FirstOrDefaultAsync();
        }

        public Task<Glo_Contacto> GetByClass(int _Empresa, int _Class_ID, string _ClasseNome)
        {
            return db.Glo_Contacto.Where(x => x.Empresa_ID == _Empresa && x.Class_ID == _Class_ID && x.Class_Nome == _ClasseNome).FirstOrDefaultAsync();
        }

        public Task<Glo_Contacto> GetByTelefone(int _Empresa, int value)
        {
            return db.Glo_Contacto.Where(x => x.Empresa_ID == _Empresa && x.Telefone == value).FirstOrDefaultAsync();
        }

        public async void Create(Glo_Contacto contacto)
        {
            db.Glo_Contacto.Add(contacto);
            await db.SaveChangesAsync();
        }

        public async void Update(Glo_Contacto contacto)
        {
            db.Entry<Glo_Contacto>(contacto).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public void Deleted(Glo_Contacto contacto)
        {
            Update(contacto);
        }

        public void Dispose()
        {
            db.Dispose();
            GC.Collect();
        }
    }
}
