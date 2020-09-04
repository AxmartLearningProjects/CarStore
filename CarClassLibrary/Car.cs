using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {

            Make = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;

        }

        public Car(string makeName, string modelName, int priceAmount)
        {
            Make = makeName;
            Model = modelName;
            Price = priceAmount;


        }



    }
}
