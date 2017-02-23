using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SuperFacil.Infraestructure.CrossCutting.Configuration
{
    public class ApplicationSignInManager: SignInManager<ApplicationUser, string>
    {
        public ApplicationSignInManager(ApplicationUserManager _UserManager, IAuthenticationManager _AuthenticationManager): base(_UserManager, _AuthenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(ApplicationUser user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager) UserManager);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext _Context)
        {
            return new ApplicationSignInManager(_Context.GetUserManager<ApplicationUserManager>(), _Context.Authentication);
        }
    }
}
