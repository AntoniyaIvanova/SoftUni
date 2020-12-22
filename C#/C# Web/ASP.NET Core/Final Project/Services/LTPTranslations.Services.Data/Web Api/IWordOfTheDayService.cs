namespace LTPTranslations.Services.Data.Web_Api
{
    using LTPTranslations.Web.ViewModels.ViewModels.WordOfTheDay;

    public interface IWordOfTheDayService
    {
        WordOfTheDayInputModel GetById();
    }
}
