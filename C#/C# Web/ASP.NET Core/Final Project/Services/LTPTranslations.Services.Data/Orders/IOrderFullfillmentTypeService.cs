namespace LTPTranslations.Services.Data.Orders
{
    using System.Collections.Generic;

    public interface IOrderFullfillmentTypeService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllFullfillmentTypes();
    }
}
