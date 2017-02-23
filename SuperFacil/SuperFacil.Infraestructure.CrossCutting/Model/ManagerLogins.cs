using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Collections.Generic;

namespace SuperFacil.Infraestructure.CrossCutting.Model
{
    public class ManagerLogins
    {
        public IList<UserLoginInfo> CurrentUser { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }

    }
}
