namespace LTPTranslations.Services.Data.Web_Api
{
    using System;
    using System.Linq;

    using LTPTranslations.Data.Common.Repositories;
    using LTPTranslations.Data.Models.WebApi;
    using LTPTranslations.Web.ViewModels.ViewModels.WordOfTheDay;

    public class WordOfTheDayService : IWordOfTheDayService
    {
        private readonly IDeletableEntityRepository<WordOfTheDay> wordOfTheDayRepository;

        public WordOfTheDayService(IDeletableEntityRepository<WordOfTheDay> wordOfTheDayRepository)
        {
            this.wordOfTheDayRepository = wordOfTheDayRepository;
        }

        public WordOfTheDayInputModel GetById()
        {
            var rand = new Random();
            var wordsInDatabase = this.wordOfTheDayRepository.All()
                                                             .Select(x => new
                                                             {
                                                                 x.Id,
                                                             })
                                                             .ToList()
                                                             .Count;

            int randomId = rand.Next(1, wordsInDatabase + 1);

            var randomWord = this.wordOfTheDayRepository
                           .AllAsNoTracking()
                           .Where(x => x.Id == randomId)
                           .Select(x => new WordOfTheDayInputModel
                           {
                               OriginalWord = x.OriginalWord,
                               Meaning = x.Meaning,
                               Pronunciation = x.Pronunciation,
                               PartOfSpeech = x.PartOfSpeech,
                               OtherSynonyms = x.OtherSynonyms.Select(y => new SynonymsInputModel
                               {
                                   SynonymName = y.SynonymName,
                               }).ToList(),
                           })
                           .FirstOrDefault();

            return randomWord;
        }
    }
}
