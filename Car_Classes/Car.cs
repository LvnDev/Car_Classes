using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Classes
{
    public class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public string Color;
        public int Mileage;

        public double DetermineMarketValue()
        {
            double carValue;

            if (this.Year > 1990)
                carValue = 3860.0;
            else
                carValue = 2000.0;

            if (this.Mileage > 900.0)
                carValue -= 100.0;
            else if (this.Mileage > 9000.0)
                carValue -= 600.0;
            return carValue;
        }
    }
}