namespace LTPTranslations.Data.Models.Legalizations
{
    using System;

    using LTPTranslations.Data.Common.Models;

    public class DocumentType : BaseDeletableModel<string>
    {
        public DocumentType()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }
    }
}
