using SuperFacil.Domain.Entities.Sistema;
using SuperFacil.Domain.Interface.Repositories.Sistema;
using SuperFacil.Domain.Interface.Services.Sistema;

namespace SuperFacil.Services.Sistema
{
    public class Sis_Empresa_Service : ServiceBase<Sis_Empresa>, ISis_Empresa_Service
    {
        private readonly ISis_Empresa_Repository _Repository;

        public Sis_Empresa_Service(ISis_Empresa_Repository Repository):base(Repository)
        {
            _Repository = Repository;
        }  
    }
}
