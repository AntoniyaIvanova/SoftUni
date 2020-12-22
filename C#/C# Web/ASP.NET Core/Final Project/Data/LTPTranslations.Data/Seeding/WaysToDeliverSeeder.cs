namespace LTPTranslations.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using LTPTranslations.Data.Models.Orders;

    public class WaysToDeliverSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.DeliveryTypes.Any())
            {
                return;
            }

            var deliveryTypes = new List<string> { "Е-мейл", "Вземане от наш офис", "Изпращане по куриер" };

            foreach (var deliveryType in deliveryTypes)
            {
                await dbContext.DeliveryTypes.AddAsync(new DeliveryType
                {
                    Name = deliveryType,
                });
            }

            var firstType = new DeliveryType
            {
                Name = "Е-мейл",
                Price = 1,
            };

            var secondType = new DeliveryType
            {
                Name = "Вземане от наш офис",
                Price = 2,
            };

            var thirdType = new DeliveryType
            {
                Name = "Изпращане по куриер",
                Price = 3,
            };

            await dbContext.DeliveryTypes.AddAsync(firstType);
            await dbContext.DeliveryTypes.AddAsync(secondType);
            await dbContext.DeliveryTypes.AddAsync(thirdType);
        }
    }
}
