namespace LTPTranslations.Data.Models.CompanyInformation
{
    using LTPTranslations.Data.Common.Models;

    public class ContactForm : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }
}
