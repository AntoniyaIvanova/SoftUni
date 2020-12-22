namespace LTPTranslations.Services.Data.Orders
{
    using System.Linq;
    using System.Threading.Tasks;

    using LTPTranslations.Data.Common.Repositories;
    using LTPTranslations.Data.Models.Legalizations;
    using LTPTranslations.Data.Models.Orders;
    using LTPTranslations.Data.Models.Translations;
    using LTPTranslations.Web.ViewModels.Calculator;
    using LTPTranslations.Web.ViewModels.ViewModels.Calculator;

    public class OfferService : IOfferService
    {
        private readonly IDeletableEntityRepository<Order> orderRepository;
        private readonly IDeletableEntityRepository<LanguagePair> languagePairRepository;
        private readonly IDeletableEntityRepository<DocumentType> documentTypeRepository;
        private readonly IDeletableEntityRepository<DeliveryType> deliveryTypeRepository;

        public OfferService(
            IDeletableEntityRepository<Order> orderRepository,
            IDeletableEntityRepository<LanguagePair> languagePairRepository,
            IDeletableEntityRepository<DocumentType> documentTypeRepository,
            IDeletableEntityRepository<DeliveryType> deliveryTypeRepository)
        {
            this.orderRepository = orderRepository;
            this.languagePairRepository = languagePairRepository;
            this.documentTypeRepository = documentTypeRepository;
            this.deliveryTypeRepository = deliveryTypeRepository;
        }

        public async Task<string> CreateAsync(CalculatorOptionsInputModel input)
        {
            var orderToBe = new Order
            {
                OrderTypeId = input.OrderTypeId,
                TimeForFullfillmentId = input.OrderSpeedFullfilment,
                DocumentTypeId = input.TypeOfTheDocument,
                Pages = input.Pages,
                DeliveryTypeId = input.WayToReceive,
                IsAccepted = false,
            };

            var languagePair = this.languagePairRepository
                                       .AllAsNoTracking()
                                       .Where(x => x.LanguageFromId == input.LanguageFrom && x.LanguageToId == input.LanguageTo)
                                       .Select(y => new
                                       {
                                           y.Id,
                                       })
                                       .FirstOrDefault();

            orderToBe.LanguagePairId = languagePair.Id;

            var documentTypePrice = this.documentTypeRepository
                                       .AllAsNoTracking()
                                       .Where(x => x.Id == input.TypeOfTheDocument)
                                       .Select(y => new
                                       {
                                           y.Price,
                                       })
                                       .FirstOrDefault();

            var translationPairPrice = this.languagePairRepository
                                       .AllAsNoTracking()
                                       .Where(x => x.LanguageFromId == input.LanguageFrom && x.LanguageToId == input.LanguageTo)
                                       .Select(y => new
                                       {
                                           y.Price,
                                       })
                                       .FirstOrDefault();

            var deliveryTypePrice = this.deliveryTypeRepository
                                     .AllAsNoTracking()
                                     .Where(x => x.Id == input.WayToReceive)
                                     .Select(y => new
                                     {
                                         y.Price,
                                     })
                                     .FirstOrDefault();

            orderToBe.PriceOffer = documentTypePrice.Price + (translationPairPrice.Price * input.Pages) + deliveryTypePrice.Price;

            await this.orderRepository.AddAsync(orderToBe);

            await this.orderRepository.SaveChangesAsync();

            return orderToBe.Id;
        }

        public OfferViewModel GetById(string id)
        {
            var offer = this.orderRepository
                            .AllAsNoTracking()
                            .Where(x => x.Id == id)
                            .Select(x => new OfferViewModel
                            {
                                OrderTypeName = x.OrderType.Name,
                                FullfilmentSpeedName = x.TimeForFullfillment.Name,
                                DocumentTypeName = x.DocumentType.Name,
                                PagesNumber = x.Pages,
                                LanguageFromName = x.LanguagePair.LanguageFrom.Name,
                                LanguageToName = x.LanguagePair.LanguageTo.Name,
                                WayToReceiveName = x.DeliveryType.Name,
                                PriceOfferNumber = x.PriceOffer,
                                CreatedOnDate = x.CreatedOn,
                            })
                            .FirstOrDefault();

            return offer;
        }
    }
}
