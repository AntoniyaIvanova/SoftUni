namespace LTPTranslations.Data.Models.CompanyInformation
{
    using System.Collections.Generic;

    using LTPTranslations.Data.Common.Models;
    using LTPTranslations.Data.Models.Moderators;

    public class Office : BaseDeletableModel<int>
    {
        public Office()
        {
            this.Moderators = new HashSet<Moderator>();
        }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public ICollection<Moderator> Moderators { get; set; }
    }
}
