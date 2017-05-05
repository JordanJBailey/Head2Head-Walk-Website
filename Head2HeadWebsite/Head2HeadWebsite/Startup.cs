using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Head2HeadWebsite.Startup))]
namespace Head2HeadWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
