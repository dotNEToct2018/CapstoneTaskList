using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGitCapstoneTaskList.Startup))]
namespace TestGitCapstoneTaskList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
