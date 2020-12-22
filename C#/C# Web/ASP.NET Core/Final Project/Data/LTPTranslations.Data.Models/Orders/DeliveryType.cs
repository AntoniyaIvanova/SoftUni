namespace LTPTranslations.Data.Models.Orders
{
    using LTPTranslations.Data.Common.Models;

    public class DeliveryType : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
