namespace LTPTranslations.Data.Models.Invoices
{
    using LTPTranslations.Data.Common.Models;

    public class InvoiceStatus : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
