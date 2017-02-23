using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace SuperFacil.Infraestructure.CrossCutting.Configuration
{
    public class EmailService: IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage _Message)
        {
            return Task.FromResult(0);
        }
    }
}
