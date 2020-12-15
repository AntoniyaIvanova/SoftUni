namespace LTPTranslations.Data.Models
{
    using System.Collections.Generic;

    public class LegalizingAuthority
    {
        public LegalizingAuthority()
        {
            this.Documents = new HashSet<Document>();
            this.AuthorityLegalizationTimeSpans = new HashSet<AuthorityLegalizationTimeSpan>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string ContactPerson { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ICollection<AuthorityLegalizationTimeSpan> AuthorityLegalizationTimeSpans { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
