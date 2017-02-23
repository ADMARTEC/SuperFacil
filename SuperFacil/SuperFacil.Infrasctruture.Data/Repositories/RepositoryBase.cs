using SuperFacil.Domain.Interface;
using SuperFacil.Infrasctruture.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace SuperFacil.Infrasctruture.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected SuperFacilContext db = new SuperFacilContext();

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await db.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetID(int _ID)
        {
            return await db.Set<TEntity>().FindAsync(_ID);
        }

        public void Create(TEntity _obj)
        {
            db.Set<TEntity>().Add(_obj);
            db.SaveChangesAsync();
        }

        public void Update(TEntity _obj)
        {
            db.Entry(_obj).State = EntityState.Modified;
            db.SaveChangesAsync();
        }

        public void Delete(TEntity _obj)
        {
            Update(_obj);
        }

        public void Dispose()
        {
            db.Dispose();
        }
        
    }
}
