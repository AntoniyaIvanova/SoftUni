namespace LTPTranslations.Data.Models.Orders
{
    using LTPTranslations.Data.Common.Models;

    public class OrderType : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
