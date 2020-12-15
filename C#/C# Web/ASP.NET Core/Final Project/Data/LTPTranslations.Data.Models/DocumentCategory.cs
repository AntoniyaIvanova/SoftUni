namespace LTPTranslations.Data.Models
{
    using System.Collections.Generic;

    public class DocumentCategory
    {
        public DocumentCategory()
        {
            this.Documents = new HashSet<Document>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
