namespace LTPTranslations.Data.Models.CompanyInformation
{
    using System;
    using System.Collections.Generic;

    using LTPTranslations.Data.Common.Models;

    public class Company : BaseDeletableModel<string>
    {
        public Company()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Offices = new HashSet<Office>();
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string IdentificationNumberRegNo { get; set; }

        public string VATNo { get; set; }

        public virtual ICollection<Office> Offices { get; set; }
    }
}
