namespace LTPTranslations.Data.Models.Translations
{
    using System;

    using LTPTranslations.Data.Common.Models;

    public class DocumentForTranslation : BaseDeletableModel<string>
    {
        public DocumentForTranslation()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string OriginalText { get; set; }

        public string TranslatedText { get; set; }
    }
}
