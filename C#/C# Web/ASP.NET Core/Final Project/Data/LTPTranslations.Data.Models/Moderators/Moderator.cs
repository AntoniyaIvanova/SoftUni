namespace LTPTranslations.Data.Models.Moderators
{
    using System;
    using System.Collections.Generic;

    using LTPTranslations.Data.Models.Orders;

    public class Moderator
    {
        public Moderator()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Orders = new HashSet<Order>();
        }

        public string Id { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
