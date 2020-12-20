namespace LTPTranslations.Services.Data.Orders
{
    using System.Collections.Generic;

    public interface IDocumentTypeService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllDocumentTypes();
    }
}
