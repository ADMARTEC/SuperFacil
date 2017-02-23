using SuperFacil.Domain.Entities.GestEmpresa.Financas.Bancos;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Financas.Bancos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Financas.Bancos
{
    public class Fin_Banco_Conta_TPA_Service : ServiceBase<Fin_Banco_Conta_TPA>, IFin_Banco_Conta_TPA_Service
    {
        public Fin_Banco_Conta_TPA_Service(IRepositoryBase<Fin_Banco_Conta_TPA> repository) : base(repository)
        {
        }
    }
}
