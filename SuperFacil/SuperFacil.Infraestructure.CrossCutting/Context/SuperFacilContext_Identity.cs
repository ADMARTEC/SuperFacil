using Microsoft.AspNet.Identity.EntityFramework;
using SuperFacil.Infraestructure.CrossCutting.Configuration;
using System;

namespace SuperFacil.Infraestructure.CrossCutting.Context
{
    public class SuperFacilContext_Identity: IdentityDbContext<ApplicationUser>,IDisposable
    {
        public SuperFacilContext_Identity():base("SuperFacilConexaoString", throwIfV1Schema :false)
        {
        }

        public static SuperFacilContext_Identity Create()
        {
            return new SuperFacilContext_Identity();
        }

    }
}
