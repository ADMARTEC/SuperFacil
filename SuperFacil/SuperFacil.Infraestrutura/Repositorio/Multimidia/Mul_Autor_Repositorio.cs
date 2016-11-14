using SuperFacil.Dominio.Contratos.Repositorios.Multimidia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFacil.Dominio.Modelos.Multimidia;
using System.Data.Entity;

namespace SuperFacil.Infraestrutura.Repositorio.Multimidia
    {
    public class Mul_Autor_Repositorio : IMul_Autor_Repositorio
        {

        private SuperFacilContexto db;
        public Mul_Autor_Repositorio(SuperFacilContexto _db)
            {
            db = _db;
            }
        public async void Create(Mul_Autor autor)
            {
            db.Mul_Autor.Add(autor);
            await db.SaveChangesAsync();
            }

        public void Deleted(Mul_Autor autor)
            {
            Update(autor);
            }

        public void Dispose()
            {
            db.Dispose();
            GC.Collect();
            }

        public Task<Mul_Autor> GetByDesiginacao(int Empresa, string value)
            {
            return db.Mul_Autor.Where(x => x.Empresa_ID == Empresa && x.Designacao == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Autor> GetByID(int Empresa, int value)
            {
            return db.Mul_Autor.Where(x => x.Empresa_ID == Empresa && x.Autor_ID == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Autor> GetByBiografiaID(int Empresa, int value)
            {
            return db.Mul_Autor.Where(x => x.Empresa_ID == Empresa && x.Biografia_ID == value).FirstOrDefaultAsync();
            }

        public async void Update(Mul_Autor autor)
            {
            db.Entry<Mul_Autor>(autor).State = EntityState.Modified;
            await db.SaveChangesAsync();
            }

        public Task<Mul_Autor> GetByNome(int Empresa, string value)
            {
            return db.Mul_Autor.Where(x => x.Empresa_ID == Empresa && x.Nome == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Autor> GetBySobrenome(int Empresa, string value)
            {
            return db.Mul_Autor.Where(x => x.Empresa_ID == Empresa && x.Sobrenome == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Autor> GetByAlcunha(int Empresa, string value)
            {
            return db.Mul_Autor.Where(x => x.Empresa_ID == Empresa && x.Alcunha == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Autor> GetByDesiginacao(int Empresa, string _Nome, string _Sobrenome)
            {
            return db.Mul_Autor.Where(x => x.Empresa_ID == Empresa && x.Nome == _Nome && x.Sobrenome == _Sobrenome).FirstOrDefaultAsync();
            }

        public Task<Mul_Autor> GetByDesiginacao(int Empresa, string _Nome, string _Sobrenome, string Alcunha)
            {
            return db.Mul_Autor.Where(x => x.Empresa_ID == Empresa && x.Nome == _Nome && x.Sobrenome == _Sobrenome && x.Alcunha == Alcunha).FirstOrDefaultAsync();
            }
        }
    }
