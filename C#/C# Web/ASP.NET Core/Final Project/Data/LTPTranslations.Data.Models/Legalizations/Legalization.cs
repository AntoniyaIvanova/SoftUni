namespace LTPTranslations.Data.Models.Legalizations
{
    using System;

    using LTPTranslations.Data.Common.Models;

    public class Legalization : BaseDeletableModel<string>
    {
        public Legalization()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string CourierId { get; set; }

        public Courier Courier { get; set; }

        public string DocumentForLegalizationId { get; set; }

        public DocumentForLegalization DocumentForLegalization { get; set; }
    }
}
