using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FaceBook_Connect.Startup))]
namespace FaceBook_Connect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
