namespace LTPTranslations.Services.Data.Orders
{
    using System.Threading.Tasks;

    using LTPTranslations.Data.Common.Repositories;
    using LTPTranslations.Data.Models.Orders;
    using LTPTranslations.Web.ViewModels.Calculator;

    public class OfferService : IOfferService
    {
        private readonly IDeletableEntityRepository<Order> orderRepository;

        public OfferService(IDeletableEntityRepository<Order> orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public async Task CreateAsync(CalculatorOptionsInputModel input)
        {
            var orderToBe = new Order
            {
                OrderTypeId = input.OrderTypeId,
                TimeForFullfillmentId = input.OrderSpeedFullfilment,
                DocumentTypeId = input.TypeOfTheDocument,
                Pages = input.Pages,
                LanguageFromId = input.LanguageFrom,
                LanguageToId = input.LanguageTo,
                DeliveryTypeId = input.WayToReceive,
                PriceOffer = input.PriceOffer,
                IsAccepted = false,
            };

            await this.orderRepository.AddAsync(orderToBe);

            await this.orderRepository.SaveChangesAsync();
        }
    }
}
