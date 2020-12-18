namespace LTPTranslations.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using LTPTranslations.Data.Models.Legalizations;

    public class LegalizationAgencySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.LegalizingAuthorities.Any())
            {
                return;
            }

            var agencies = new List<string> { "Министерство на правосъдието", "Министерство на образованието", "НАП", "Консулски отдел" };

            foreach (var agency in agencies)
            {
                await dbContext.LegalizingAuthorities.AddAsync(new LegalizingAuthority
                {
                    Name = agency,
                });
            }
        }
    }
}
