namespace LTPTranslations.Data.Models.Legalizations
{
    using System;

    public class LegalizationProcess
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TimeSpan TimeNeeded { get; set; }

        public decimal StateTax { get; set; }
    }
}
