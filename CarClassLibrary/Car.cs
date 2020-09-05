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
        public string Color { get; set; }
        public bool Is4Wheeler { get; set; }


        public Car()
        {

            Make = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;
            Color = "nothing yet";
            Is4Wheeler = false;
        }

        public Car(string makeName, string modelName, decimal priceAmount, string colorName, bool is4WheelerCar)
        {
            Make = makeName;
            Model = modelName;
            Price = priceAmount;
            Color = colorName;
            Is4Wheeler = is4WheelerCar;

        }

        override public string ToString()
        {
            return $"Make : {Make} Model : {Model} Price :{Price} Color: {Color} 4 wheeler: {Is4Wheeler}";

        }


    }
}
