namespace LTPTranslations.Data.Models.Legalizations
{
    using LTPTranslations.Data.Common.Models;

    public class DocumentType : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
