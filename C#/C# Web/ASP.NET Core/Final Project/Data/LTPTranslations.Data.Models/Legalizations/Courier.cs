namespace LTPTranslations.Data.Models.Legalizations
{
    using System;
    using System.Collections.Generic;

    public class Courier
    {
        public Courier()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<Legalization> Legalizations { get; set; }
    }
}
