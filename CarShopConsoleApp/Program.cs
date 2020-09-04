using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Store s = new Store();

            Console.WriteLine("Welcome to the car store. First You must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout wich will give you a total value of the shopping cart.");


            int action = chooseAction();
            while (action != 0)
            {
                Console.WriteLine($"You choose {action}");

                switch (action)
                {
                    case 1:
                        Console.WriteLine("You choose to add a new car to the inventory");

                        string carMake = string.Empty;
                        string carModel = string.Empty;
                        decimal carPrice = 0.00M;

                        Console.WriteLine("What is the car make?");
                        carMake = Console.ReadLine();
                        Console.WriteLine("What is the car model?");
                        carModel = Console.ReadLine();
                        Console.WriteLine("What is the car price?");
                        carPrice = decimal.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake, carModel, carPrice);
                        s.CarList.Add(newCar);

                        printInventory(s);

                        break;


                    default:
                        break;
                }

                action = chooseAction();
            }

   

        }

        private static void printInventory(Store s)
        {
            foreach (var c in s.CarList)
            {
                Console.WriteLine($"Car : {c}");
            }
        }

        public static int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new car to inventory (2) add car to cart (3) checkout");
            choice = int.Parse(Console.ReadLine());
            return choice;



        }
    }
}
