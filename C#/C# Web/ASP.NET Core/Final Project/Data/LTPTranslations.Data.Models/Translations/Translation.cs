namespace LTPTranslations.Data.Models.Translations
{
    using System;
    using System.Collections.Generic;

    using LTPTranslations.Data.Models;
    using LTPTranslations.Data.Models.ModelRelationships;

    public class Translation
    {
        public Translation()
        {
            this.Id = Guid.NewGuid().ToString();
            this.TranslationsTranslators = new HashSet<TranslationTranslator>();
            this.Comments = new HashSet<Comment>();
        }

        public string Id { get; set; }

        public int PagesCountId { get; set; }

        public PagesCount PagesCount { get; set; }

        public int TimeForFullfillmentId { get; set; }

        public TimeForFullfillment TimeForFullfillment { get; set; }

        public int LanguagePairId { get; set; }

        public LanguagePair LanguagePair { get; set; }

        public string DocumentForTranslationId { get; set; }

        public DocumentForTranslation DocumentForTranslation { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<TranslationTranslator> TranslationsTranslators { get; set; }
    }
}
