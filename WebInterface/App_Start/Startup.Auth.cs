using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace WebInterface
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            // No authentication required.
        }
    }
}