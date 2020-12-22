namespace LTPTranslations.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using LTPTranslations.Data.Models.WebApi;

    public class WordOfTheDaySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.WordsOfTheDay.Any())
            {
                return;
            }

            var firstWord = new WordOfTheDay
            {
                OriginalWord = "translation",
                Meaning = "превод",
                Pronunciation = "trænsˈleɪʃən",
                PartOfSpeech = "съществително име",
            };

            var secondWord = new WordOfTheDay
            {
                OriginalWord = "adaptation",
                Meaning = "адаптация",
                Pronunciation = "ˌædæpˈteɪʃ(ə)n",
                PartOfSpeech = "съществително име",
            };

            var thirdWord = new WordOfTheDay
            {
                OriginalWord = "write",
                Meaning = "пиша",
                Pronunciation = "raɪt",
                PartOfSpeech = "глагол",
            };

            firstWord.OtherSynonyms.Add(new Synonyms
            {
                SynonymName = "adaptation",
            });

            secondWord.OtherSynonyms.Add(new Synonyms
            {
                SynonymName = "translation",
            });

            secondWord.OtherSynonyms.Add(new Synonyms
            {
                SynonymName = "transfer",
            });

            await dbContext.WordsOfTheDay.AddAsync(firstWord);
            await dbContext.WordsOfTheDay.AddAsync(secondWord);
            await dbContext.WordsOfTheDay.AddAsync(thirdWord);
        }
    }
}
