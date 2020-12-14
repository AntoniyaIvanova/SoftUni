namespace LTPTranslations.Data.Models.ModelRelationships
{
    using LTPTranslations.Data.Models.Translations;
    using LTPTranslations.Data.Models.Translator;

    public class TranslationTranslator
    {
        public string TranslatorId { get; set; }

        public Translator Translator { get; set; }

        public string TranslationId { get; set; }

        public Translation Translation { get; set; }
    }
}
