namespace LTPTranslations.Data.Models.Translations
{
    using System;
    using System.Collections.Generic;

    using LTPTranslations.Data.Models;
    using LTPTranslations.Data.Models.ModelRelationships;
    using LTPTranslations.Data.Models.Orders;

    public class Translation
    {
        public Translation()
        {
            this.Id = Guid.NewGuid().ToString();
            this.TranslationsTranslators = new HashSet<TranslationTranslator>();
            this.Comments = new HashSet<Comment>();
        }

        public string Id { get; set; }

        public string DocumentId { get; set; }

        public DocumentForTranslation DocumentForTranslation { get; set; }

        public int LanguagePairId { get; set; }

        public LanguagePair LanguagePair { get; set; }

        public int FullFillmentTypeId { get; set; }

        public FullfillmentType FullfillmentType { get; set; }

        public int TimeForFullfillmentId { get; set; }

        public TimeForFullfillment TimeForFullfillment { get; set; }

        public decimal PagesCount { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<TranslationTranslator> TranslationsTranslators { get; set; }
    }
}
