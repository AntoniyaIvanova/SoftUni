namespace LTPTranslations.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class WordOfTheDaysController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
