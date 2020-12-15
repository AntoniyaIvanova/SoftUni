namespace LTPTranslations.Data.Models
{
    public class AuthorityLegalizationTimeSpan
    {
        public int LegalizingAuthorityId { get; set; }

        public LegalizingAuthority LegalizingAuthority { get; set; }

        public int LegalizationTimeSpanId { get; set; }

        public LegalizationTimeSpan LegalizationTimeSpan { get; set; }
    }
}
