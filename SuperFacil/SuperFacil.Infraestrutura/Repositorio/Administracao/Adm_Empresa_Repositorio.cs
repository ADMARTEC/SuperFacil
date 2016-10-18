using SuperFacil.Dominio.Contratos.Repositorios.Administracao;
using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Repositorio.Administracao
{
    public class Adm_Empresa_Repositorio : IAdm_Empresa_Repositorio
    {
        private SuperFacilContexto db;

        public Adm_Empresa_Repositorio(SuperFacilContexto _db)
        {
            db = _db;
        }

        public Task<Adm_Empresa> GetByID(int value)
        {
            return db.Adm_Empresa.Where(x => x.Empresa_ID == value).FirstOrDefaultAsync();
        }

        public Task<Adm_Empresa> GetByNIF(int Empresa, string value)
        {
            return db.Adm_Empresa.Where(x => x.Empresa_ID == Empresa && x.NIF == value).FirstOrDefaultAsync();
        }

        public Task<Adm_Empresa> GetByParent(int Empresa, int value)
        {
            return db.Adm_Empresa.Where(x => x.Empresa_ID == Empresa && x.Parent_ID == value).FirstOrDefaultAsync();
        }

        public async void Create(Adm_Empresa empresa)
        {
            db.Adm_Empresa.Add(empresa);
            await db.SaveChangesAsync();
        }

        public async void Update(Adm_Empresa empresa)
        {
            db.Entry<Adm_Empresa>(empresa).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public void Deleted(Adm_Empresa empresa)
        {
            Update(empresa);
        }

        public void Dispose()
        {
            db.Dispose();
            GC.Collect();
        }
    }
}
