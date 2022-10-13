using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Classes
{
    public partial class Default : System.Web.UI.Page
    {               
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] carsMake = { "Ford", "Mercades", "BMW" };

            Car myNewCar = new Car(); // car 1 ford

            myNewCar.Make = carsMake[0];
            myNewCar.Model = "Focus";
            myNewCar.Year = 2017;
            myNewCar.Color = "Black";
            myNewCar.Mileage = 9000;
         

            Car myNewCar1 = new Car(); //car 2 mercades

            myNewCar1.Make = carsMake[1];
            myNewCar1.Model = "AMG";
            myNewCar1.Year = 2021;
            myNewCar1.Color = "Blue";
            myNewCar1.Mileage = 500;
            
            
            Car myNewCar2 = new Car(); // car 3 BMW

            myNewCar2.Make = carsMake[2];
            myNewCar2.Model = "Series 3";
            myNewCar2.Year = 1989;
            myNewCar2.Color = "Red";
            myNewCar2.Mileage = 16000;

            printCar(myNewCar);
            printCar(myNewCar1);
            printCar(myNewCar2);
         

        }

        protected void printCar(Car car)
        {
            double myMarketValueOfCar = car.DetermineMarketValue();

            Label1.Text += String.Format("{0} - {1} - {2} - {3} - {4} Milege - {5:C}<p>",
             car.Make,
             car.Model,
             car.Year.ToString(),
             car.Color,
             car.Mileage.ToString(),
             myMarketValueOfCar);
        }

    }
}