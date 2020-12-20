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
        }
    }
}
