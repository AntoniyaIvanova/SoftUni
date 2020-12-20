namespace LTPTranslations.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using LTPTranslations.Data.Models.Translations;

    public class LanguageToSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.LanguagesTo.Any())
            {
                return;
            }

            var languagesFrom = new List<string> { "Английски език", "Немски език", "Български език", "Италиански език" };

            foreach (var languageFrom in languagesFrom)
            {
                await dbContext.LanguagesTo.AddAsync(new LanguageTo
                {
                    Name = languageFrom,
                });
            }
        }
    }
}
