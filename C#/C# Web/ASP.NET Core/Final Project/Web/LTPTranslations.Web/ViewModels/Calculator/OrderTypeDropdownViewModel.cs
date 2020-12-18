namespace LTPTranslations.Web.ViewModels.Calculator
{
    using LTPTranslations.Data.Models.Orders;
    using LTPTranslations.Services.Mapping;

    public class OrderTypeDropdownViewModel : IMapFrom<OrderType>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
