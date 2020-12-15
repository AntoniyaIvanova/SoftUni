namespace LTPTranslations.Data.Models.Translations
{
    using System;

    public class FullfillmentType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TimeSpan TimeNeeded { get; set; }

        public decimal Quote { get; set; }
    }
}
