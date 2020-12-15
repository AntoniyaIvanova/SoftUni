namespace LTPTranslations.Data.Models
{
    using System;

    public class LegalizationTimeSpan
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TimeSpan TimeNeededForLegalization { get; set; }
    }
}
