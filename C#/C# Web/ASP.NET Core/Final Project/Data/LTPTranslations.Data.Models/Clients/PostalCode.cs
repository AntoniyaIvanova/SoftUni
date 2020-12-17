namespace LTPTranslations.Data.Models.Clients
{
    using LTPTranslations.Data.Common.Models;

    public class PostalCode : BaseDeletableModel<int>
    {
        public string PostalCodeContent { get; set; }
    }
}
