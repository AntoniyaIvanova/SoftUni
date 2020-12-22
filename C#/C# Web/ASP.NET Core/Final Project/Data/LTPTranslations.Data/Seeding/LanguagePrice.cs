namespace LTPTranslations.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using LTPTranslations.Data.Models.Translations;

    public class LanguagePrice : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.LanguagePairs.Any())
            {
                return;
            }

            var firstLanguagePari = new LanguagePair
            {
                LanguageFromId = 4,
                LanguageToId = 5,
                Price = 10,
            };

            await dbContext.LanguagePairs.AddAsync(firstLanguagePari);
        }
    }
}
