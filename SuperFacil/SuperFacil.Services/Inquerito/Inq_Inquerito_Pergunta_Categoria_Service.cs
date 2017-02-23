using SuperFacil.Domain.Entities.Inquerito;
using SuperFacil.Domain.Interface.Repositories.Inquerito;
using SuperFacil.Domain.Interface.Services.Inquerito;

namespace SuperFacil.Services.Inquerito
{
    public class Inq_Inquerito_Pergunta_Categoria_Service : ServiceBase<Inq_Inquerito_Pergunta_Categoria>, IInq_Inquerito_Pergunta_Categoria_Service
    {
        private readonly IInq_Inquerito_Pergunta_Categoria_Repository _Repository;

        public Inq_Inquerito_Pergunta_Categoria_Service(IInq_Inquerito_Pergunta_Categoria_Repository Repository):base(Repository)
        {
            _Repository = Repository;
        }
       
    }
}
