namespace LTPTranslations.Data.Models.Translator
{
    using System;
    using System.Collections.Generic;

    using LTPTranslations.Data.Common.Models;

    public class ConsularCertification : BaseDeletableModel<string>
    {
        public ConsularCertification()
        {
            this.Id = Guid.NewGuid().ToString();
            this.UniviersityDiplomas = new HashSet<UniversityDiploma>();
        }

        public string ConsularDeclaration { get; set; }

        public string SecondaryEducationDiploma { get; set; }

        public ICollection<UniversityDiploma> UniviersityDiplomas { get; set; }
    }
}
