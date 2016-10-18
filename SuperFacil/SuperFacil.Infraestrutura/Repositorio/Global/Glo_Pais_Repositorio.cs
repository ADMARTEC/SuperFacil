using SuperFacil.Dominio.Contratos.Repositorios.Global;
using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Repositorio.Global
{
    public class Glo_Pais_Repositorio : IGlo_Pais_Repositorio
    {
        private SuperFacilContexto db;

        public Glo_Pais_Repositorio(SuperFacilContexto _db)
        {
            db = _db;
        }

        public Task<Glo_Pais> GetByID(int _Empresa, int value)
        {
            return db.Glo_Pais.Where(x => x.Empresa_ID == _Empresa && x.Pais_ID == value).FirstOrDefaultAsync();
        }

        public Task<Glo_Pais> GetByParent(int _Empresa, int value)
        {
            return db.Glo_Pais.Where(x => x.Empresa_ID == _Empresa && x.Parent_ID == value).FirstOrDefaultAsync();
        }

        public Task<Glo_Pais> GetByDesignacao(int _Empresa, string value)
        {
            return db.Glo_Pais.Where(x => x.Empresa_ID == _Empresa && x.Designacao == value).FirstOrDefaultAsync();
        }

        public async void Create(Glo_Pais pais)
        {
            db.Glo_Pais.Add(pais);
            await db.SaveChangesAsync();
        }
        public void Update(Glo_Pais pais)
        {
            db.Entry<Glo_Pais>(pais).State = EntityState.Modified;
            db.SaveChangesAsync();
        }

        public void Deleted(Glo_Pais pais)
        {
            Update(pais);
        }

        public void Dispose()
        {
            db.Dispose();
            GC.Collect();
        }


    }
}
