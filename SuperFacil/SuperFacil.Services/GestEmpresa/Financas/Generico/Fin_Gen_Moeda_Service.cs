using SuperFacil.Domain.Entities.GestEmpresa.Financas.Generico;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Financas.Generico;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Financas.Generico
{
    public class Fin_Gen_Moeda_Service : ServiceBase<Fin_Gen_Moeda>, IFin_Gen_Moeda_Service
    {
        public Fin_Gen_Moeda_Service(IRepositoryBase<Fin_Gen_Moeda> repository) : base(repository)
        {
        }
    }
}
