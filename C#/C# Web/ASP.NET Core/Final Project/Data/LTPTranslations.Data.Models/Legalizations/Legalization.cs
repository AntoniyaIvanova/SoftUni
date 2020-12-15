namespace LTPTranslations.Data.Models.Legalizations
{
    using System;

    public class Legalization
    {
        public Legalization()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string CourierId { get; set; }

        public Courier Courier { get; set; }

        public string DocumentForLegalizationId { get; set; }

        public DocumentForLegalization DocumentForLegalization { get; set; }
    }
}
