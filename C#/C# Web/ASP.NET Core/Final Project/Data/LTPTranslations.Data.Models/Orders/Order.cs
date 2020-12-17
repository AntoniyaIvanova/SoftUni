﻿namespace LTPTranslations.Data.Models.Orders
{
    using System;
    using System.Collections.Generic;

    using LTPTranslations.Data.Common.Models;
    using LTPTranslations.Data.Models.Clients;
    using LTPTranslations.Data.Models.Invoices;
    using LTPTranslations.Data.Models.Legalizations;
    using LTPTranslations.Data.Models.Moderators;
    using LTPTranslations.Data.Models.Translations;

    public class Order : BaseDeletableModel<string>
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Translations = new HashSet<Translation>();
            this.Legalizations = new HashSet<Legalization>();
        }

        public string InvoiceId { get; set; }

        public Invoice Invoice { get; set; }

        public string ClientId { get; set; }

        public Client Client { get; set; }

        public string ModeartorId { get; set; }

        public Moderator Moderator { get; set; }

        public int TimeForFullfillmentId { get; set; }

        public TimeForFullfillment TimeForFullfillment { get; set; }

        public virtual ICollection<Translation> Translations { get; set; }

        public virtual ICollection<Legalization> Legalizations { get; set; }
    }
}
