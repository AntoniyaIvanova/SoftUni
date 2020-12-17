namespace LTPTranslations.Data.Models.Legalizations
{
    using LTPTranslations.Data.Common.Models;

    public class DocumentForLegalization : BaseDeletableModel<int>
    {
        public string DocumentUrl { get; set; }

        public int LegalizingAuthorityId { get; set; }

        public LegalizingAuthority LegalizingAuthority { get; set; }

        public string DocumentTypeId { get; set; }

        public DocumentType DocumentType { get; set; }
    }
}
