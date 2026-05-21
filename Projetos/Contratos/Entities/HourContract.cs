using System;
using System.Collections.Generic;
using System.Text;

namespace Contratos.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValourPerHour { get; set; }
        public int Hours { get; set; }

        public HourContract (DateTime date, double valourPerHour, int hours)
        {
            Date = date;
            ValourPerHour = valourPerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValourPerHour * Hours;
        }
    }
}
