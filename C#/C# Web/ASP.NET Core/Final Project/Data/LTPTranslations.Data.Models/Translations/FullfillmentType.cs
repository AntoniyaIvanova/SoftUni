namespace LTPTranslations.Data.Models.Translations
{
    using System;

    using LTPTranslations.Data.Common.Models;

    public class FullfillmentType : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public TimeSpan TimeNeeded { get; set; }

        public decimal Quote { get; set; }
    }
}
