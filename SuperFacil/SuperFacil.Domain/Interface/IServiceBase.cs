using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Domain.Interface
{
    public interface IServiceBase<TEntity> where TEntity:class
    {
        Task<TEntity> GetID(int _ID);
        Task<IEnumerable<TEntity>> GetAll();
        void Create(TEntity _obj);
        void Update(TEntity _obj);
        void Delete(TEntity _obj);
        void Dispose();
    }
}
