namespace LTPTranslations.Data.Seeding
{
    using System;
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

            var firstType = new TimeForFullfillment
            {
                Name = "Нормална",
                Price = 1,
            };

            var secondType = new TimeForFullfillment
            {
                Name = "Бърза",
                Price = 2,
            };

            var thirdType = new TimeForFullfillment
            {
                Name = "Експресна",
                Price = 3,
            };

            await dbContext.TimeForFullfillments.AddAsync(firstType);
            await dbContext.TimeForFullfillments.AddAsync(secondType);
            await dbContext.TimeForFullfillments.AddAsync(thirdType);
        }
    }
}
