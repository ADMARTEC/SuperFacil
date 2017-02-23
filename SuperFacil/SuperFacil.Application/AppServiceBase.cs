using SuperFacil.Application.Interface;
using SuperFacil.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _service;

        public AppServiceBase(IServiceBase<TEntity> service)
        {
            _service = service;
        }
        public async Task<IEnumerable<TEntity>> GetAll()
        {
           return await _service.GetAll();
        }

        public async Task<TEntity> GetID(int _ID)
        {
            return await _service.GetID(_ID);
        }

        public void Create(TEntity _obj)
        {
            _service.Create(_obj);
        }

        public void Update(TEntity _obj)
        {
            _service.Update(_obj);
        }
        public void Delete(TEntity _obj)
        {
            _service.Delete(_obj);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}
