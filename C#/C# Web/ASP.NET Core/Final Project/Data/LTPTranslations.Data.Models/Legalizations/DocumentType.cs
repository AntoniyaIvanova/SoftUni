namespace LTPTranslations.Data.Models.Legalizations
{
    using System;

    public class DocumentType
    {
        public DocumentType()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Name { get; set; }
    }
}
