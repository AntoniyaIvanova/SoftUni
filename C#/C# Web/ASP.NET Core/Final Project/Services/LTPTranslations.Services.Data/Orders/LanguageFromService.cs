namespace LTPTranslations.Services.Data.Orders
{
    using System.Collections.Generic;
    using System.Linq;

    using LTPTranslations.Data.Common.Repositories;
    using LTPTranslations.Data.Models.Translations;

    public class LanguageFromService : ILanguageFromService
    {
        private readonly IDeletableEntityRepository<LanguageFrom> languageFromTypesRepository;

        public LanguageFromService(IDeletableEntityRepository<LanguageFrom> languageFromTypesRepository)
        {
            this.languageFromTypesRepository = languageFromTypesRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllLanguagesFromTypes()
        {
            return this.languageFromTypesRepository.All().Select(x => new
            {
                x.Id,
                x.Name,
            }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
