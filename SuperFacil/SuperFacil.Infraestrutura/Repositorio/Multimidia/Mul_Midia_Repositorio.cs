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
    public class Mul_Midia_Repositorio : IMul_Midia_Repositorio
        {
        private SuperFacilContexto db;

        public Mul_Midia_Repositorio(SuperFacilContexto _db)
            {
            db = _db;
            }
        public async void Create(Mul_Midia midia)
            {
            db.Mul_Midia.Add(midia);
            await db.SaveChangesAsync();
            }

        public void Deleted(Mul_Midia midia)
            {
            Update(midia);
            }
        public async void Update(Mul_Midia midia)
            {
            db.Entry<Mul_Midia>(midia).State = EntityState.Modified;
            await db.SaveChangesAsync();
            }
        public void Dispose()
            {
            db.Dispose();
            GC.Collect();
            }

        public Task<Mul_Midia> GetByAno_Lancamento(int Empresa, int Parent, DateTime value)
            {
            return db.Mul_Midia.Where(x => x.Empresa_ID == Empresa && x.Parent_ID == Parent && x.Ano_Lancamento == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Midia> GetByAutor(int Empresa, int value)
            {
            return db.Mul_Midia.Where(x => x.Empresa_ID == Empresa && x.Autor_ID == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Midia> GetByDesiginacao(int Empresa, int Parent, string value)
            {
            return db.Mul_Midia.Where(x => x.Empresa_ID == Empresa && x.Parent_ID == Parent && x.Designacao == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Midia> GetByFaixa(int Empresa, int Parent, int value)
            {
            return db.Mul_Midia.Where(x => x.Empresa_ID == Empresa && x.Parent_ID == Parent && x.Faixa == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Midia> GetByID(int Empresa, int value)
            {
            return db.Mul_Midia.Where(x => x.Empresa_ID == Empresa && x.Midia_ID == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Midia> GetByLocalizacao(int Empresa, int Parent, int value)
            {
            return db.Mul_Midia.Where(x => x.Empresa_ID == Empresa && x.Parent_ID == Parent && x.Localizacao_ID == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Midia> GetByParent(int Empresa, int value)
            {
            return db.Mul_Midia.Where(x => x.Empresa_ID == Empresa && x.Parent_ID == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Midia> GetByTag(int Empresa, int Parent, string value)
            {
            return db.Mul_Midia.Where(x => x.Empresa_ID == Empresa && x.Parent_ID == Parent && x.Tag == value).FirstOrDefaultAsync();
            }
        }
    }
