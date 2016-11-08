using SuperFacil.Dominio.Contratos.Repositorios.Global;
using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Repositorio.Global
{
    public class Glo_Imagem_Repositorio : IGlo_Imagem_Repositorio
    {
        private SuperFacilContexto db;

        public Glo_Imagem_Repositorio(SuperFacilContexto _db)
        {
            db = _db;
        }

        public Task<Glo_Imagem> GetByID(int value)
        {
            return db.Glo_Imagem.Where(x => x.Imagem_ID == value).FirstOrDefaultAsync();
        }

        public Task<Glo_Imagem> GetByID(int Empresa, int value)
        {
            return db.Glo_Imagem.Where(x => x.Empresa_ID == Empresa && x.Imagem_ID == value).FirstOrDefaultAsync();
        }

        public Task<Glo_Imagem> GetByLastID(int Empresa)
        {
            return db.Glo_Imagem.Where(x => x.Empresa_ID == Empresa).MaxAsync();
        }

        public Task<Glo_Imagem> GetByDesignacao(int Empresa, string value)
        {
            return db.Glo_Imagem.Where(x => x.Empresa_ID == Empresa && x.Designacao == value).FirstOrDefaultAsync();
        }

        public async void Create(Glo_Imagem imagem)
        {
            db.Glo_Imagem.Add(imagem);
            await db.SaveChangesAsync();
        }

        public async void Update(Glo_Imagem imagem)
        {
            db.Entry<Glo_Imagem>(imagem).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public void Deleted(Glo_Imagem imagem)
        {
            Update(imagem);
        }

        public void Dispose()
        {
            db.Dispose();
            GC.Collect();
        }   
    }
}
