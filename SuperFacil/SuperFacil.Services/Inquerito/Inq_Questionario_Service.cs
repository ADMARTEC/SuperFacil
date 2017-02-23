using SuperFacil.Domain.Entities.Inquerito;
using SuperFacil.Domain.Interface.Repositories.Inquerito;
using SuperFacil.Domain.Interface.Services.Inquerito;

namespace SuperFacil.Services.Inquerito
{
    public class Inq_Questionario_Service : ServiceBase<Inq_Questionario>, IInq_Questionario_Service
    {
        private readonly IInq_Questionario_Repository _Repository;

        public Inq_Questionario_Service(IInq_Questionario_Repository Repository):base(Repository)
        {
            _Repository = Repository;
        }
    }
}
