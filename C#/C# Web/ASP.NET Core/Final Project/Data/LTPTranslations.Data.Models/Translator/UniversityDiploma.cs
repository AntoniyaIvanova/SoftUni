namespace LTPTranslations.Data.Models.Translator
{
    using System;

    using LTPTranslations.Data.Common.Models;

    public class UniversityDiploma : BaseDeletableModel<string>
    {
        public UniversityDiploma()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Diploma { get; set; }
    }
}
