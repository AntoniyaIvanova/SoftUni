namespace LTPTranslations.Services.Data.Orders
{
    using System.Collections.Generic;
    using System.Linq;

    using LTPTranslations.Data.Common.Repositories;
    using LTPTranslations.Data.Models.Orders;

    public class OrderTypeService : IOrderTypeService
    {
        private readonly IDeletableEntityRepository<OrderType> orderTypesRepository;

        public OrderTypeService(IDeletableEntityRepository<OrderType> orderTypesRepository)
        {
            this.orderTypesRepository = orderTypesRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllOrderTypes()
        {
            return this.orderTypesRepository.All().Select(x => new
            {
                x.Id,
                x.Name,
            }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
