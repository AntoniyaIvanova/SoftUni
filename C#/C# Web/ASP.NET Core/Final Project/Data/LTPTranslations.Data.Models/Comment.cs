namespace LTPTranslations.Data.Models
{
    using System;

    using LTPTranslations.Data.Common.Models;

    public class Comment : BaseDeletableModel<string>
    {
        public Comment()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Content { get; set; }
    }
}
