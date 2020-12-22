namespace LTPTranslations.Services.Data.Orders
{
    using System.Threading.Tasks;

    using LTPTranslations.Web.ViewModels.Calculator;
    using LTPTranslations.Web.ViewModels.ViewModels.Calculator;

    public interface IOfferService
    {
        Task<string> CreateAsync(CalculatorOptionsInputModel input);

        OfferViewModel GetById(string id);
    }
}
