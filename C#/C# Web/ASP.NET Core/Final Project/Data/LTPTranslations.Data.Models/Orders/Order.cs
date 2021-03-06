﻿namespace LTPTranslations.Data.Models.Orders
{
    using System;

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
        }

        public string InvoiceId { get; set; }

        public Invoice Invoice { get; set; }

        public string ClientId { get; set; }

        public Client Client { get; set; }

        public string ModeartorId { get; set; }

        public Moderator Moderator { get; set; }

        public int OrderTypeId { get; set; }

        public OrderType OrderType { get; set; }

        public int TimeForFullfillmentId { get; set; }

        public TimeForFullfillment TimeForFullfillment { get; set; }

        public int LanguagePairId { get; set; }

        public LanguagePair LanguagePair { get; set; }

        public int DeliveryTypeId { get; set; }

        public DeliveryType DeliveryType { get; set; }

        public int DocumentTypeId { get; set; }

        public DocumentType DocumentType { get; set; }

        public decimal PriceOffer { get; set; }

        public bool IsAccepted { get; set; }

        public decimal Pages { get; set; }
    }
}
