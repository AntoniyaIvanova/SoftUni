namespace LTPTranslations.Data.Models.CompanyInformation
{
    using System.Collections.Generic;

    using LTPTranslations.Data.Models.Moderators;

    public class Office
    {
        public Office()
        {
            this.Moderators = new HashSet<Moderator>();
        }

        public int Id { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public ICollection<Moderator> Moderators { get; set; }
    }
}
