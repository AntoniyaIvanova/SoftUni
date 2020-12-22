namespace LTPTranslations.Services.Data.Orders
{
    using System.Threading.Tasks;

    using LTPTranslations.Web.ViewModels.Calculator;

    public interface IOfferService
    {
        Task CreateAsync(CalculatorOptionsInputModel input);
    }
}
