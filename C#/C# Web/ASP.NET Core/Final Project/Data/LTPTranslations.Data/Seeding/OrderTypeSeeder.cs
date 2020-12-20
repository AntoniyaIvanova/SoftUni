namespace LTPTranslations.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using LTPTranslations.Data.Models.Orders;

    public class OrderTypeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.OrderTypes.Any())
            {
                return;
            }

            var orderTypes = new List<string> { "Превод", "Легализация", "Превод и легализация" };

            foreach (var type in orderTypes)
            {
                await dbContext.OrderTypes.AddAsync(new OrderType
                {
                    Name = type,
                });
            }
        }
    }
}
