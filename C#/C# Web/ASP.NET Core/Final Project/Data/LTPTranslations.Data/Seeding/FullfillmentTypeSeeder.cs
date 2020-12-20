namespace LTPTranslations.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using LTPTranslations.Data.Models.Orders;

    public class FullfillmentTypeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.TimeForFullfillments.Any())
            {
                return;
            }

            var fullfillmentTypes = new List<string> { "Нормална", "Бърза", "Експресна" };

            foreach (var fullfillmentType in fullfillmentTypes)
            {
                await dbContext.TimeForFullfillments.AddAsync(new TimeForFullfillment
                {
                    Name = fullfillmentType,
                });
            }
        }
    }
}
