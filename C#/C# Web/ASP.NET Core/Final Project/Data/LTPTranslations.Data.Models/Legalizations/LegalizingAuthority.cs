namespace LTPTranslations.Data.Models.Legalizations
{
    using System.Collections.Generic;

    using LTPTranslations.Data.Common.Models;

    public class LegalizingAuthority : BaseDeletableModel<int>
    {
        public LegalizingAuthority()
        {
            this.DocumentTypes = new HashSet<DocumentType>();
            this.LegalizationProcesses = new HashSet<LegalizationProcess>();
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string ContactPerson { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ICollection<LegalizationProcess> LegalizationProcesses { get; set; }

        public virtual ICollection<DocumentType> DocumentTypes { get; set; }
    }
}
