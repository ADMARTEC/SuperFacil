using SuperFacil.Domain.Entities.GestEmpresa.Financas.Bancos;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Financas.Bancos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Financas.Bancos
{
    public class Fin_Banco_Conta_Service : ServiceBase<Fin_Banco_Conta>, IFin_Banco_Conta_Service
    {
        public Fin_Banco_Conta_Service(IRepositoryBase<Fin_Banco_Conta> repository) : base(repository)
        {
        }
    }
}
