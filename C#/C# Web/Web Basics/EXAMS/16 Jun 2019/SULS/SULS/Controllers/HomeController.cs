using SIS.HTTP;
using SIS.MvcFramework;

namespace SULS.App.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public HttpResponse IndexSlash()
        {
            return this.Index();
        }

        public HttpResponse Index()
        {
            return this.View();
        }
    }
}