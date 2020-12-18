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

            var documents = new List<string> { "Пълномощно", "Свидетелство за съдимост", "Диплома за средно образование", "Приложение към диплома за средно образование", "Удостоверение от НАП" };

            foreach (var document in documents)
            {
                await dbContext.DocumentTypes.AddAsync(new DocumentType
                {
                    Name = document,
                });
            }
        }
    }
}
