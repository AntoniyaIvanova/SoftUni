namespace LTPTranslations.Data.Models.WebApi
{
    using LTPTranslations.Data.Common.Models;

    public class Synonyms : BaseDeletableModel<int>
    {
        public string SynonymName { get; set; }
    }
}
