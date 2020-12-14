namespace LTPTranslations.Data.Models.Orders
{
    using System;

    public class Order
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
    }
}
