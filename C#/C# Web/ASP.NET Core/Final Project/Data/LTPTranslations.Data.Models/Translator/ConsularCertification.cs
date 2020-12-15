namespace LTPTranslations.Data.Models.Translator
{
    using System;
    using System.Collections.Generic;

    public class ConsularCertification
    {
        public ConsularCertification()
        {
            this.Id = Guid.NewGuid().ToString();
            this.UniviersityDiplomas = new HashSet<UniversityDiploma>();
        }

        public string Id { get; set; }

        public string ConsularDeclaration { get; set; }

        public string SecondaryEducationDiploma { get; set; }

        public ICollection<UniversityDiploma> UniviersityDiplomas { get; set; }
    }
}
