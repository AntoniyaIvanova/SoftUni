namespace LTPTranslations.Data.Models.Clients
{
    using System;

    using LTPTranslations.Data.Common.Models;

    public class AddressInformation : BaseDeletableModel<string>
    {
        public AddressInformation()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public int PostalCodeId { get; set; }

        public PostalCode PostalCode { get; set; }

        public string AddressLine { get; set; }
    }
}
