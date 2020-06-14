using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineMedicalStore.Startup))]
namespace OnlineMedicalStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
