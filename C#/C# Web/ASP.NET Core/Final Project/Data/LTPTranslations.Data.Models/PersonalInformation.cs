namespace LTPTranslations.Data.Models
{
    using System;

    public class PersonalInformation
    {
        public PersonalInformation()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
