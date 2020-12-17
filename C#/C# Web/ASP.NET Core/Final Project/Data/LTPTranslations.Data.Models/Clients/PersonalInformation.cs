namespace LTPTranslations.Data.Models.Clients
{
    using System;

    using LTPTranslations.Data.Common.Models;

    public class PersonalInformation : BaseDeletableModel<string>
    {
        public PersonalInformation()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TelephoneNumber { get; set; }

        public string Email { get; set; }
    }
}
