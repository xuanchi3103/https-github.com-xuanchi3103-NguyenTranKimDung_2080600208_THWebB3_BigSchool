using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenTranKimDung_2080600208_THWebB3.Startup))]
namespace NguyenTranKimDung_2080600208_THWebB3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
