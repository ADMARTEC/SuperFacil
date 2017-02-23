using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using SuperFacil.Infraestructure.CrossCutting.Context;

namespace SuperFacil.Infraestructure.CrossCutting.Configuration
{
    public class ApplicationRoleManager: RoleManager<IdentityRole>
    {
        public ApplicationRoleManager(IRoleStore<IdentityRole, string> _RoleStore): base(_RoleStore)
        {
        }
        public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options, IOwinContext _Context)
        {
            return new ApplicationRoleManager(new RoleStore<IdentityRole>(_Context.Get<SuperFacilContext_Identity>()));
        }
    }
}
