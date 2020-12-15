namespace LTPTranslations.Data.Models.Legalizations
{
    using System;

    public class Legalization
    {
        public Legalization()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
    }
}
