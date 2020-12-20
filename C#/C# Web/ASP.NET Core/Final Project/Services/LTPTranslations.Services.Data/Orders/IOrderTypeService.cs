namespace LTPTranslations.Services.Data.Orders
{
    using System.Collections.Generic;

    public interface IOrderTypeService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllOrderTypes();
    }
}
