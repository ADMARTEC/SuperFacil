using SuperFacil.Domain.Entities.GestEmpresa.Financas.Bancos;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Financas.Bancos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Financas.Bancos
{
    public class Fin_Banco_Service : ServiceBase<Fin_Banco>, IFin_Banco_Service
    {
        public Fin_Banco_Service(IRepositoryBase<Fin_Banco> repository) : base(repository)
        {
        }
    }
}
