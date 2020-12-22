namespace LTPTranslations.Data.Models.Translations
{
    using LTPTranslations.Data.Common.Models;

    public class LanguagePair : BaseDeletableModel<int>
    {
        public int LanguageFromId { get; set; }

        public LanguageFrom LanguageFrom { get; set; }

        public int LanguageToId { get; set; }

        public LanguageTo LanguageTo { get; set; }

        public decimal Price { get; set; }
    }
}
