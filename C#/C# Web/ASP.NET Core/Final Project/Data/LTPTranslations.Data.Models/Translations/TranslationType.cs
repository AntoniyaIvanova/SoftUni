namespace LTPTranslations.Data.Models.Translations
{
    using System;

    public class TranslationType
    {
        public TranslationType()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Name { get; set; }
    }
}
