using SuperFacil.Application.Interface;
using SuperFacil.Application.Interface.Inquerito;
using SuperFacil.Domain.Entities.Inquerito;
using SuperFacil.Domain.Interface.Services.Inquerito;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFacil.Domain.Services.Inquerito
{
    public class Inq_Inquerito_Pergunta_Categoria_AppService : IAppServiceBase<Inq_Inquerito_Pergunta_Categoria>, IInq_Inquerito_Pergunta_Categoria_AppService
    {
        private readonly IInq_Inquerito_Pergunta_Categoria_Service _Service;

        public Inq_Inquerito_Pergunta_Categoria_AppService(IInq_Inquerito_Pergunta_Categoria_Service Service)
        {
            _Service = Service;
        }

        public async Task<IEnumerable<Inq_Inquerito_Pergunta_Categoria>> GetAll()
        {
            return await _Service.GetAll();
        }

        public async Task<Inq_Inquerito_Pergunta_Categoria> GetID(int _ID)
        {
            return await _Service.GetID(_ID);
        }

        public void Create(Inq_Inquerito_Pergunta_Categoria _obj)
        {
            _Service.Create(_obj);
        }

        public void Update(Inq_Inquerito_Pergunta_Categoria _obj)
        {
            _Service.Update(_obj);
        }

        public void Delete(Inq_Inquerito_Pergunta_Categoria _obj)
        {
            _Service.Delete(_obj);
        }

        public void Dispose()
        {
            _Service.Dispose();
        }
    }
}
