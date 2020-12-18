namespace LTPTranslations.Data.Models.CompanyInformation
{
    using LTPTranslations.Data.Common.Models;

    public class ContactFormEntry : BaseModel<int>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public string Ip { get; set; }
    }
}
