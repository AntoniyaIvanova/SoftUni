namespace LTPTranslations.Data.Models.Translations
{
    public class LanguagePair
    {
        public int Id { get; set; }

        public string LanguageFromId { get; set; }

        public LanguageFrom LanguageFrom { get; set; }

        public string LanguageToId { get; set; }

        public LanguageFrom Language { get; set; }
    }
}
