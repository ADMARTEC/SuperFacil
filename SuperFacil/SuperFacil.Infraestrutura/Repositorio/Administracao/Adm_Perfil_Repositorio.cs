using SuperFacil.Dominio.Contratos.Repositorios.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Administracao;
using System.Data.Entity;

namespace SuperFacil.Infraestrutura.Repositorio.Administracao
{
    public class Adm_Perfil_Repositorio : IAdm_Perfil_Repositorio
    {
        private SuperFacilContexto db;

        public Adm_Perfil_Repositorio(SuperFacilContexto _db)
        {
            db = _db;
        }

        public Task<Adm_Perfil> GetByID(int Empresa, int value)
        {
            return db.Adm_Perfil.Where(x => x.Empresa_ID == Empresa && x.Perfil_ID == value).FirstOrDefaultAsync();
        }

        public Task<Adm_Perfil> GetByParent(int Empresa, int value)
        {
            return db.Adm_Perfil.Where(x => x.Empresa_ID == Empresa && x.Parent_ID == value).FirstOrDefaultAsync();
        }

        public Task<Adm_Perfil> GetByDesiginacao(int Empresa, string value)
        {
            return db.Adm_Perfil.Where(x => x.Empresa_ID == Empresa && x.Designacao == value).FirstOrDefaultAsync();
        }

        public Task<Adm_Perfil> GetByHorarioAcesso(int Empresa, int value)
        {
            return db.Adm_Perfil.Where(x => x.Empresa_ID == Empresa && x.HorarioAcesso_ID == value).FirstOrDefaultAsync();
        }

        public async void Create(Adm_Perfil perfil)
        {
            db.Adm_Perfil.Add(perfil);
            await db.SaveChangesAsync();
        }

        public async void Update(Adm_Perfil perfil)
        {
            db.Entry<Adm_Perfil>(perfil).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public void Deleted(Adm_Perfil perfil)
        {
            Update(perfil);
        }

        public void Dispose()
        {
            db.Dispose();
            GC.Collect();
        }
    }
}
