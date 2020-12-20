namespace LTPTranslations.Services.Data.Orders
{
    using System.Collections.Generic;
    using System.Linq;

    using LTPTranslations.Data.Common.Repositories;
    using LTPTranslations.Data.Models.Legalizations;

    public class DocumentTypeService : IDocumentTypeService
    {
        private readonly IDeletableEntityRepository<DocumentType> documentTypesRepository;

        public DocumentTypeService(IDeletableEntityRepository<DocumentType> documentTypesRepository)
        {
            this.documentTypesRepository = documentTypesRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllDocumentTypes()
        {
            return this.documentTypesRepository.All().Select(x => new
            {
                x.Id,
                x.Name,
            }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
