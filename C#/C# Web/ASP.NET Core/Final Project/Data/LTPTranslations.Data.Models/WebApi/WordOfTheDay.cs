namespace LTPTranslations.Data.Models.WebApi
{
    using System.Collections.Generic;

    using LTPTranslations.Data.Common.Models;

    public class WordOfTheDay : BaseDeletableModel<int>
    {
        public WordOfTheDay()
        {
            this.OtherSynonyms = new HashSet<Synonyms>();
        }

        public string OriginalWord { get; set; }

        public string Meaning { get; set; }

        public string Pronunciation { get; set; }

        public string PartOfSpeech { get; set; }

        public ICollection<Synonyms> OtherSynonyms { get; set; }
    }
}
