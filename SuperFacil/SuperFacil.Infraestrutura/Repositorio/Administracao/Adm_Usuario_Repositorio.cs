using SuperFacil.Dominio.Contratos.Repositorios.Administracao;
using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Repositorio.Administracao
{
    public class Adm_Usuario_Repositorio : IAdm_Usuario_Repositorio
    {
        private SuperFacilContexto db;

        public Adm_Usuario_Repositorio(SuperFacilContexto _db)
        {
            // Inicia a contrução do objecto
            db = _db;
        }

        public Task<Adm_Usuario> GetByID(int Empresa, int value)
        {
            return db.Adm_Usuario.Where(x => x.Usuario_ID == value && x.Empresa_ID == Empresa).FirstOrDefaultAsync();
        }

        public Task<Adm_Usuario> GetByNome(int Empresa, string value)
        {
            return db.Adm_Usuario.Where(x => x.Empresa_ID == Empresa && x.Designacao == value).FirstOrDefaultAsync();
        }

        public Task<Adm_Usuario> GetByLogin(int Empresa, string value)
        {
            return db.Adm_Usuario.Where(x => x.Empresa_ID == Empresa && x.Usuario_login == value).FirstOrDefaultAsync();
        }

        public Task<Adm_Usuario> GetByDataLimite(int Empresa, DateTime value)
        {
            return db.Adm_Usuario.Where(x => x.Empresa_ID == Empresa && x.Data_Limite == value).FirstOrDefaultAsync();
        }

        public Task<Adm_Usuario> GetByPerfil(int Empresa, int value)
        {
            return db.Adm_Usuario.Where(x => x.Empresa_ID == Empresa && x.Perfil_ID == value).FirstOrDefaultAsync();
        }
        public async void Create(Adm_Usuario usuario)
        {
            db.Entry<Adm_Usuario>(usuario).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async void Update(Adm_Usuario usuario)
        {
            db.Adm_Usuario.Add(usuario);
            await db.SaveChangesAsync();
        }

        public void Delete(Adm_Usuario usuario)
        {
            Update(usuario);
        }

        public void Dispose()
        {
            db.Dispose();
            GC.Collect();
        }

    }
}
