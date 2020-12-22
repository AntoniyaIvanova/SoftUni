namespace LTPTranslations.Web.ViewModels.ViewModels.WordOfTheDay
{
    using System.Collections.Generic;

    public class WordOfTheDayInputModel
    {
        public string OriginalWord { get; set; }

        public string Meaning { get; set; }

        public string Pronunciation { get; set; }

        public string PartOfSpeech { get; set; }

        public IEnumerable<SynonymsInputModel> OtherSynonyms { get; set; }
    }
}
