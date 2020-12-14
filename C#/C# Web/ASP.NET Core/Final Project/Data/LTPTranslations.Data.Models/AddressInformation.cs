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
    }
}
