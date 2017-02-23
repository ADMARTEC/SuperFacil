using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Generico;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Comercial.Generico;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Comercial.Generico
{
    public class Com_Gen_PrazoPagamento_Service : ServiceBase<Com_Gen_PrazoPagamento>, ICom_Gen_PrazoPagamento_Service
    {
        public Com_Gen_PrazoPagamento_Service(IRepositoryBase<Com_Gen_PrazoPagamento> repository) : base(repository)
        {
        }
    }
}
