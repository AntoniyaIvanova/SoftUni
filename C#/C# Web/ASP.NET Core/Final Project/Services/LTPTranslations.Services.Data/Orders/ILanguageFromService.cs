namespace LTPTranslations.Services.Data.Orders
{
    using System.Collections.Generic;

    public interface ILanguageFromService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllLanguagesFromTypes();
    }
}
