using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(git_test_002.Startup))]
namespace git_test_002
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
