namespace LTPTranslations.Data.Models.Clients
{
    using System;
    using System.Collections.Generic;

    using LTPTranslations.Data.Models.Invoices;
    using LTPTranslations.Data.Models.Orders;

    public class Client
    {
        public Client()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Orders = new HashSet<Order>();
            this.Invoices = new HashSet<Invoice>();
        }

        public string Id { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public string PersonalInformationId { get; set; }

        public PersonalInformation PersonalInfomation { get; set; }

        public string AddressInformationId { get; set; }

        public AddressInformation AddressInformation { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
