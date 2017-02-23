using SuperFacil.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _Repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _Repository = repository;
        }

        public Task<IEnumerable<TEntity>> GetAll()
        {
            return _Repository.GetAll();
        }

        public Task<TEntity> GetID(int _ID)
        {
            return _Repository.GetID(_ID);
        }

        public void Create(TEntity _obj)
        {
            _Repository.Create(_obj);
        }

        public void Update(TEntity _obj)
        {
            _Repository.Update(_obj);
        }
        public void Delete(TEntity _obj)
        {
            _Repository.Delete(_obj);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
