namespace LTPTranslations.Data.Models
{
    using System;
    using System.Collections.Generic;

    using LTPTranslations.Data.Models.Orders;

    public class Client
    {
        public Client()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Orders = new HashSet<Order>();
        }

        public string Id { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
