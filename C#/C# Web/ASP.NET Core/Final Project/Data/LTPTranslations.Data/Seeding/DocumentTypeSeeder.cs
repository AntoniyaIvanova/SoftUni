namespace LTPTranslations.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using LTPTranslations.Data.Models.Legalizations;

    public class DocumentTypeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.DocumentTypes.Any())
            {
                return;
            }

            var firstDocument = new DocumentType
            {
                Name = "Пълномощно",
                Price = 15,
            };

            var secondDocument = new DocumentType
            {
                Name = "Свидетелство за съдимост",
                Price = 5,
            };

            var thirdDocument = new DocumentType
            {
                Name = "Диплома за средно образование",
                Price = 1,
            };

            var fourthDocument = new DocumentType
            {
                Name = "Приложение към диплома за средно образование",
                Price = 2,
            };

            await dbContext.DocumentTypes.AddAsync(firstDocument);
            await dbContext.DocumentTypes.AddAsync(secondDocument);
            await dbContext.DocumentTypes.AddAsync(thirdDocument);
            await dbContext.DocumentTypes.AddAsync(fourthDocument);
        }
    }
}
