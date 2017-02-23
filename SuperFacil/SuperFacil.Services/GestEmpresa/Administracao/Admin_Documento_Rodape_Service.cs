using SuperFacil.Domain.Entities.GestEmpresa.Administracao;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Administracao;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Administracao
{
    public class Admin_Documento_Rodape_Service : ServiceBase<Admin_Documento_Rodape>, IAdmin_Documento_Rodape_Service
    {
        public Admin_Documento_Rodape_Service(IRepositoryBase<Admin_Documento_Rodape> repository) : base(repository)
        {
        }
    }
}
