namespace LTPTranslations.Web.ViewModels.ViewModels.Calculator
{
    using System;

    public class OfferViewModel
    {
        public string OrderTypeName { get; set; }

        public string FullfilmentSpeedName { get; set; }

        public string DocumentTypeName { get; set; }

        public decimal PagesNumber { get; set; }

        public string LanguageFromName { get; set; }

        public string LanguageToName { get; set; }

        public string WayToReceiveName { get; set; }

        public decimal PriceOfferNumber { get; set; }

        public DateTime CreatedOnDate { get; set; }
    }
}
