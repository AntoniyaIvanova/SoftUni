namespace LTPTranslations.Web.ViewModels.Calculator
{
    using System.Collections.Generic;

    public class CalculatorOptionsViewModel
    {
        public int OrderType { get; set; }

        public IEnumerable<OrderTypeDropdownViewModel> OrderTypeItems { get; set; }

        public int OrderSpeedFullfilment { get; set; }

        public int TypeOfTheDocument { get; set; }

        public decimal Pages { get; set; }

        public int LanguageFrom { get; set; }

        public int LanguageTo { get; set; }

        public int WayToReceive { get; set; }
    }
}
