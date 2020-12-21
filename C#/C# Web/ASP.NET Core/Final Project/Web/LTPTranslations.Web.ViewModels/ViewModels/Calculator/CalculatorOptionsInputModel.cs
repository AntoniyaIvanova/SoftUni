namespace LTPTranslations.Web.ViewModels.Calculator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CalculatorOptionsInputModel
    {
        [Required(ErrorMessage = "Моля, изберете типа на услугата")]
        [Display(Name = "Тип на услугата")]
        public int OrderTypeId { get; set; }

        [Required(ErrorMessage = "Моля, изберете срока за изпълнение на услугата")]
        [Display(Name = "Срок на изпълнение")]
        public int OrderSpeedFullfilment { get; set; }

        [Required(ErrorMessage = "Моля, изберете вида на документа")]
        [Display(Name = "Вид на документа")]
        public int TypeOfTheDocument { get; set; }

        [Required(ErrorMessage = "Моля, въведете ориентировъчния брои страници")]
        [Display(Name = "Брой страници")]
        [Range(0.0, double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public int Pages { get; set; }

        [Required(ErrorMessage = "Моля, изберете език на оригинала")]
        [Display(Name = "Превод от")]
        public int LanguageFrom { get; set; }

        [Required(ErrorMessage = "Моля, изберете езика за превод")]
        [Display(Name = "Превод на")]
        public int LanguageTo { get; set; }

        [Required(ErrorMessage = "Моля, изберете начин на получаване на услугата")]
        [Display(Name = "Начин на получаване")]
        public int WayToReceive { get; set; }

        [Display(Name = "Обща сума:")]
        public decimal PriceOffer { get; set; }

        public IEnumerable<KeyValuePair<string, string>> OrderTypeItems { get; set; }

        public IEnumerable<KeyValuePair<string, string>> OrderFullfilmentTypeItems { get; set; }

        public IEnumerable<KeyValuePair<string, string>> DocumentTypeItems { get; set; }

        public IEnumerable<KeyValuePair<string, string>> LanguageFromItems { get; set; }

        public IEnumerable<KeyValuePair<string, string>> LanguageToItems { get; set; }

        public IEnumerable<KeyValuePair<string, string>> WayToReceiveItems { get; set; }
    }
}
