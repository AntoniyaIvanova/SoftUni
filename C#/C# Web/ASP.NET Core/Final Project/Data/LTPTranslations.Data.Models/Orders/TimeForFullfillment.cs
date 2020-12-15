namespace LTPTranslations.Data.Models.Orders
{
    using System;

    public class TimeForFullfillment
    {
        public int Id { get; set; }

        public DateTime AssignedOn { get; set; }

        public DateTime ReadyBy { get; set; }
    }
}
