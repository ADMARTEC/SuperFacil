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
    public class Mul_Biografia_Repositorio : IMul_Biografia_Repositorio
        {
        private SuperFacilContexto db;
        public Mul_Biografia_Repositorio(SuperFacilContexto _db)
            {
            db = _db;
            }

        public async void Create(Mul_Biografia biografia)
            {
            db.Mul_Biografia.Add(biografia);
            await db.SaveChangesAsync();
            }

        public void Deleted(Mul_Biografia biografia)
            {
            Update(biografia);
            }

        public void Dispose()
            {
            db.Dispose();
            GC.Collect();
            }

        public Task<Mul_Biografia> GetByDesiginacao(int Empresa, string value)
            {
            return db.Mul_Biografia.Where(x => x.Empresa_ID == Empresa && x.Designacao == value).FirstOrDefaultAsync();
            }

        public Task<Mul_Biografia> GetByID(int Empresa, int value)
            {
            return db.Mul_Biografia.Where(x => x.Empresa_ID == Empresa && x.Biografia_ID == value).FirstOrDefaultAsync();
            }

        public async void Update(Mul_Biografia biografia)
            {
            db.Entry<Mul_Biografia>(biografia).State = EntityState.Modified;
            await db.SaveChangesAsync();
            }
        }
    }
