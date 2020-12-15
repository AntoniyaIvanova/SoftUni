namespace LTPTranslations.Data.Models.Legalizations
{
    public class DocumentForLegalization
    {
        public int Id { get; set; }

        public string DocumentUrl { get; set; }

        public int LegalizingAuthorityId { get; set; }

        public LegalizingAuthority LegalizingAuthority { get; set; }

        public string DocumentTypeId { get; set; }

        public DocumentType DocumentType { get; set; }
    }
}
