namespace LTPTranslations.Services.Data.Orders
{
    using System.Collections.Generic;
    using System.Linq;

    using LTPTranslations.Data.Common.Repositories;
    using LTPTranslations.Data.Models.Orders;

    public class WaysToReceiveTypeService : IWaysToReceiveTypeService
    {
        private readonly IDeletableEntityRepository<DeliveryType> deliveryTypesRepository;

        public WaysToReceiveTypeService(IDeletableEntityRepository<DeliveryType> deliveryTypesRepository)
        {
            this.deliveryTypesRepository = deliveryTypesRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetWaysOfReceivingTypes()
        {
            return this.deliveryTypesRepository.All().Select(x => new
            {
                x.Id,
                x.Name,
            }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
