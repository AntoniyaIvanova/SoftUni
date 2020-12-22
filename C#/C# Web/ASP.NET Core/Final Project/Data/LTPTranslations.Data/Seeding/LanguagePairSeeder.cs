namespace LTPTranslations.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using LTPTranslations.Data.Models.Translations;

    public class LanguagePairSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.LanguagesFrom.Any())
            {
                return;
            }

            var languagesFrom = new HashSet<string> { "Английски език", "Немски език", "Български език" };

            foreach (var languageFrom in languagesFrom)
            {
                await dbContext.LanguagesFrom.AddAsync(new LanguageFrom
                {
                    Name = languageFrom,
                });
            }

            var languagesTo = new HashSet<string> { "Английски език", "Немски език", "Български език" };

            foreach (var languageTo in languagesTo)
            {
                await dbContext.LanguagesTo.AddAsync(new LanguageTo
                {
                    Name = languageTo,
                });
            }
        }
    }
}
