using SuperFacil.Domain.Entities.Sistema.Generico;
using SuperFacil.Domain.Interface.Repositories.Sistema.Generico;
using SuperFacil.Domain.Interface.Services.Sistema.Generico;

namespace SuperFacil.Services.Sistema.Generico
{
    public class Sis_Gen_Pais_Service : ServiceBase<Sis_Gen_Pais>, ISis_Gen_Pais_Service
    {
        private readonly ISis_Gen_Pais_Repository _Repository;

        public Sis_Gen_Pais_Service(ISis_Gen_Pais_Repository Repository):base(Repository)
        {
            _Repository = Repository; 
        }  
    }
}
