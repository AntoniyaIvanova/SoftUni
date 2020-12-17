namespace LTPTranslations.Data.Models.Legalizations
{
    using System;

    using LTPTranslations.Data.Common.Models;

    public class LegalizationProcess : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public TimeSpan TimeNeeded { get; set; }

        public decimal StateTax { get; set; }
    }
}
