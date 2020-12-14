namespace LTPTranslations.Data.Models.Translations
{
    using System;

    public class DocumentForTranslation
    {
        public DocumentForTranslation()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string OriginalText { get; set; }

        public string TranslatedText { get; set; }
    }
}
