using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BMPCMusicLibrary.Startup))]
namespace BMPCMusicLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
