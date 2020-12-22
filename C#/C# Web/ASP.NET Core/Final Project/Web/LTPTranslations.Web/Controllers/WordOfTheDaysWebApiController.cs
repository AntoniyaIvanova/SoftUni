namespace LTPTranslations.Web.Controllers
{
    using LTPTranslations.Services.Data.Web_Api;
    using LTPTranslations.Web.ViewModels.ViewModels.WordOfTheDay;
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    public class WordOfTheDaysWebApiController : ControllerBase
    {
        private readonly IWordOfTheDayService wordOfTheDayService;

        public WordOfTheDaysWebApiController(IWordOfTheDayService wordOfTheDayService)
        {
            this.wordOfTheDayService = wordOfTheDayService;
        }

        [HttpGet]
        public WordOfTheDayInputModel Index()
        {
            var wordOfTheDayFromDb = this.wordOfTheDayService.GetById();

            return wordOfTheDayFromDb;
        }

        //ToDo: CRUD
    }
}
