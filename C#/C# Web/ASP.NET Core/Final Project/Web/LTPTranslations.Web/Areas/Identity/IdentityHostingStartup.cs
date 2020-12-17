using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(LTPTranslations.Web.Areas.Identity.IdentityHostingStartup))]

namespace LTPTranslations.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            _ = builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}
