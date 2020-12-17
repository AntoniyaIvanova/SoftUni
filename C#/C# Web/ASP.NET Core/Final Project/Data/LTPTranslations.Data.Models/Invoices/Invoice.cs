namespace LTPTranslations.Data.Models.Invoices
{
    using System;
    using System.Collections.Generic;

    using LTPTranslations.Data.Common.Models;
    using LTPTranslations.Data.Models.Clients;
    using LTPTranslations.Data.Models.CompanyInformation;

    public class Invoice : BaseDeletableModel<string>
    {
        public Invoice()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Comments = new HashSet<Comment>();
        }

        public int InvoiceNumber { get; set; }

        public string ClientId { get; set; }

        public Client Client { get; set; }

        public int InvoiceStatusId { get; set; }

        public InvoiceStatus InvoiceStatus { get; set; }

        public int PaymentMethodId { get; set; }

        public PaymentMethod Paymentmethod { get; set; }

        public string CompanyId { get; set; }

        public Company Company { get; set; }

        public DateTime InvoiceCreatedOn { get; set; }

        public DateTime DueTo { get; set; }

        public decimal TotalAmount { get; set; }

        public string SavedAsPdf { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
