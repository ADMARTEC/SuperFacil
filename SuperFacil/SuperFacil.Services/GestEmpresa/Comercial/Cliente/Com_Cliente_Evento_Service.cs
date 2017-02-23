using SuperFacil.Domain.Interface.Services.GestEmpresa.Comercial.Cliente;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Cliente;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Comercial.Cliente
{
    public class Com_Cliente_Evento_Service : ServiceBase<Com_Cliente_Evento>, ICom_Cliente_Evento_Service
    {
        public Com_Cliente_Evento_Service(IRepositoryBase<Com_Cliente_Evento> repository) : base(repository)
        {
        }
    }
}
