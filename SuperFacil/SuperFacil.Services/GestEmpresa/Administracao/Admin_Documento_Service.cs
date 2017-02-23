using SuperFacil.Domain.Entities.GestEmpresa.Administracao;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Administracao;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Administracao
{
    public class Admin_Documento_Service : ServiceBase<Admin_Documento>, IAdmin_Documento_Service
    {
        public Admin_Documento_Service(IRepositoryBase<Admin_Documento> repository) : base(repository)
        {
        }
    }
}
