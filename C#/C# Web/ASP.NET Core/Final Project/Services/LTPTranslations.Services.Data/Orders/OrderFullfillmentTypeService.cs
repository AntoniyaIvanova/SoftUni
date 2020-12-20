namespace LTPTranslations.Services.Data.Orders
{
    using System.Collections.Generic;
    using System.Linq;

    using LTPTranslations.Data.Common.Repositories;
    using LTPTranslations.Data.Models.Orders;

    public class OrderFullfillmentTypeService : IOrderFullfillmentTypeService
    {
        private readonly IDeletableEntityRepository<TimeForFullfillment> timeForFullfillmentRepositrory;

        public OrderFullfillmentTypeService(IDeletableEntityRepository<TimeForFullfillment> timeForFullfillmentRepositrory)
        {
            this.timeForFullfillmentRepositrory = timeForFullfillmentRepositrory;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllFullfillmentTypes()
        {
            return this.timeForFullfillmentRepositrory.All().Select(x => new
            {
                x.Id,
                x.Name,
            }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
