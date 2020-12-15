namespace LTPTranslations.Data.Models.Translator
{
    using System;

    public class UniversityDiploma
    {
        public UniversityDiploma()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Diploma { get; set; }
    }
}
