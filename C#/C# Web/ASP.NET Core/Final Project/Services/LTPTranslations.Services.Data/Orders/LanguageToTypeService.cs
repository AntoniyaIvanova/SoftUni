namespace LTPTranslations.Services.Data.Orders
{
    using System.Collections.Generic;
    using System.Linq;

    using LTPTranslations.Data.Common.Repositories;
    using LTPTranslations.Data.Models.Translations;

    public class LanguageToTypeService : ILanguageToTypeService
    {
        private readonly IDeletableEntityRepository<LanguageTo> languageToTypesRepository;

        public LanguageToTypeService(IDeletableEntityRepository<LanguageTo> languageToTypesRepository)
        {
            this.languageToTypesRepository = languageToTypesRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllLanguagesToTypes()
        {
            return this.languageToTypesRepository.All().Select(x => new
            {
                x.Id,
                x.Name,
            }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
