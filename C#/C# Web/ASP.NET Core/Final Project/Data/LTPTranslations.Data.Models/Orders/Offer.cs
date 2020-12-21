namespace LTPTranslations.Data.Models.Orders
{
    using LTPTranslations.Data.Common.Models;

    public class Offer : BaseDeletableModel<int>
    {
        public decimal PriceOffer { get; set; }

        public bool IsAccepted { get; set; }
    }
}
