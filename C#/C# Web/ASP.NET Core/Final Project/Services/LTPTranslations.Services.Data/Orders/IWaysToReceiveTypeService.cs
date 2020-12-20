namespace LTPTranslations.Services.Data.Orders
{
    using System.Collections.Generic;

    public interface IWaysToReceiveTypeService
    {
        IEnumerable<KeyValuePair<string, string>> GetWaysOfReceivingTypes();
    }
}
