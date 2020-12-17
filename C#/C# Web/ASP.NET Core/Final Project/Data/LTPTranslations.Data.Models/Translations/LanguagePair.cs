namespace LTPTranslations.Data.Models.Translations
{
    using LTPTranslations.Data.Common.Models;

    public class LanguagePair : BaseDeletableModel<string>
    {
        public string LanguageFromId { get; set; }

        public LanguageFrom LanguageFrom { get; set; }

        public string LanguageToId { get; set; }

        public LanguageTo LanguageTo { get; set; }
    }
}
