using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Cliente;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Comercial.Cliente;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Comercial.Cliente
{
    public class Com_Cliente_Evento_Tipo_Service : ServiceBase<Com_Cliente_Evento_Tipo>, ICom_Cliente_Evento_Tipo_Service
    {
        public Com_Cliente_Evento_Tipo_Service(IRepositoryBase<Com_Cliente_Evento_Tipo> repository) : base(repository)
        {
        }
    }
}
