namespace LTPTranslations.Data.Models.Invoices
{
    using System;
    using System.Collections.Generic;

    using LTPTranslations.Data.Models.Clients;
    using LTPTranslations.Data.Models.CompanyInformation;

    public class Invoice
    {
        public Invoice()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Comments = new HashSet<Comment>();
        }

        public string Id { get; set; }

        public int InvoiceNumber { get; set; }

        public string ClientId { get; set; }

        public Client Client { get; set; }

        public int InvoiceStatusId { get; set; }

        public InvoiceStatus InvoiceStatus { get; set; }

        public int PaymentMethodId { get; set; }

        public PaymentMethod Paymentmethod { get; set; }

        public string CompanyId { get; set; }

        public Company Company { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime DueTo { get; set; }

        public decimal TotalAmount { get; set; }

        public string SavedAsPdf { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
