namespace LTPTranslations.Data.Models.Orders
{
    using System;

    using LTPTranslations.Data.Common.Models;

    public class TimeForFullfillment : BaseDeletableModel<int>
    {
        public DateTime AssignedOn { get; set; }

        public DateTime ReadyBy { get; set; }
    }
}
