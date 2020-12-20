namespace LTPTranslations.Services.Data.Orders
{
    using System.Collections.Generic;

    public interface ILanguageToTypeService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllLanguagesToTypes();
    }
}
