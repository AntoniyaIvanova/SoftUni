namespace LTPTranslations.Data.Models.Translator
{
    using System;
    using System.Collections.Generic;

    using LTPTranslations.Data.Models.Clients;
    using LTPTranslations.Data.Models.Translations;

    public class Translator
    {
        public Translator()
        {
            this.Id = Guid.NewGuid().ToString();
            this.LanguagePairs = new HashSet<LanguagePair>();
            this.Translations = new HashSet<Translation>();
        }

        public string Id { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public string PersonalInformationId { get; set; }

        public PersonalInformation PersonalInformation { get; set; }

        public string ConsularCertificationId { get; set; }

        public ConsularCertification ConsularCertification { get; set; }

        public virtual ICollection<PreferedTopic> PreferedTopics { get; set; }

        public virtual ICollection<LanguagePair> LanguagePairs { get; set; }

        public virtual ICollection<Translation> Translations { get; set; }
    }
}
