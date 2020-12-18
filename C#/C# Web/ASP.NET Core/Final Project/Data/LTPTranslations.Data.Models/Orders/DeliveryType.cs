namespace LTPTranslations.Data.Models.Orders
{
    using LTPTranslations.Data.Common.Models;

    public class DeliveryType : BaseDeletableModel<int>
    {
        public int Name { get; set; }
    }
}
