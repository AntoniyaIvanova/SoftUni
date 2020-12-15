namespace LTPTranslations.Data.Models
{
    using System;

    public class AddressInformation
    {
        public AddressInformation()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public int PostalCodeId { get; set; }

        public PostalCode PostalCode { get; set; }

        public string AddressLine { get; set; }
    }
}
