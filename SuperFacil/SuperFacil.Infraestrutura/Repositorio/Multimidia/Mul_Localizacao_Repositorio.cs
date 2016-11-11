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
    public class Mul_Localizacao_Repositorio : IMul_Localizacao_Repositorio
        {
        private SuperFacilContexto db;
        public Mul_Localizacao_Repositorio(SuperFacilContexto _db)
            {
            db = _db;
            }

        public async void Create(Mul_Localizacao localizacao)
            {
            db.Mul_Localizacao.Add(localizacao);
            await db.SaveChangesAsync();
            }

        public void Deleted(Mul_Localizacao localizacao)
            {
            Update(localizacao);
            }

        public void Dispose()
            {
            db.Dispose();
            GC.Collect();
            }

        public Task<Mul_Localizacao> GetByID(int Empresa, int value)
            {
            return db.Mul_Localizacao.Where(x => x.Empresa_ID == Empresa && x.Localizacao_ID == value).FirstOrDefaultAsync();
            }

        public async void Update(Mul_Localizacao localizacao)
            {
            db.Entry<Mul_Localizacao>(localizacao).State = EntityState.Modified;
            await db.SaveChangesAsync();
            }
        }
    }