using SuperFacil.Domain.Entities.GestEmpresa.Administracao;
using SuperFacil.Domain.Interface.Services.GestEmpresa.Administracao;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFacil.Domain.Interface;

namespace SuperFacil.Services.GestEmpresa.Administracao
{
    public class Admin_Documento_Numero_Service : ServiceBase<Admin_Documento_Numero>, IAdmin_Documento_Numero_Service
    {
        public Admin_Documento_Numero_Service(IRepositoryBase<Admin_Documento_Numero> repository) : base(repository)
        {
        }
    }
}
