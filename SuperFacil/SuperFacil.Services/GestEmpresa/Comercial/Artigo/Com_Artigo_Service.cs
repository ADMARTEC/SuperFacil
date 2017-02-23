using SuperFacil.Domain.Interface.Services.GestEmpresa.Comercial.Artigo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Artigo;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Comercial.Artigo
{
    public class Com_Artigo_Service : ServiceBase<Com_Artigo>, ICom_Artigo_Service
    {
        public Com_Artigo_Service(IRepositoryBase<Com_Artigo> repository) : base(repository)
        {
        }
    }
}
