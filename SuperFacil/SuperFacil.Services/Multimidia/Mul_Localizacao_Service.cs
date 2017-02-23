using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Domain.Interface.Repositories.Multimidia;
using SuperFacil.Domain.Interface.Services.Multimidia;

namespace SuperFacil.Services.Multimidia
{
    public class Mul_Localizacao_Service : ServiceBase<Mul_Localizacao>, IMul_Localizacao_Service
    {
        private readonly IMul_Localizacao_Repository _Repository;

        public Mul_Localizacao_Service(IMul_Localizacao_Repository Repository):base(Repository)
        {
            _Repository = Repository;
        }      
    }
}
