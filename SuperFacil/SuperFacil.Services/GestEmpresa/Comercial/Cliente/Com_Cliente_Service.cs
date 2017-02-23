using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Cliente;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Comercial.Cliente;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Comercial.Cliente
{
    public class Com_Cliente_Service : ServiceBase<Com_Cliente>, ICom_Cliente_Service
    {
        public Com_Cliente_Service(IRepositoryBase<Com_Cliente> repository) : base(repository)
        {
        }
    }
}
