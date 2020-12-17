namespace LTPTranslations.Data.Models.Clients
{
    using LTPTranslations.Data.Common.Models;

    public class Country : BaseDeletableModel<int>
    {
        public string CountryName { get; set; }
    }
}
