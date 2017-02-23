using SuperFacil.Domain.Entities.GestEmpresa.Comercial.Artigo;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Comercial.Artigo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Comercial.Artigo
{
    public class Com_Artigo_Preco_Service : ServiceBase<Com_Artigo_Preco>, ICom_Artigo_Preco_Service
    {
        public Com_Artigo_Preco_Service(IRepositoryBase<Com_Artigo_Preco> repository) : base(repository)
        {
        }
    }
}
