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

                    // Add item to inventory
                    case 1:
                        Console.WriteLine("You choose to add a new car to the inventory");

                        string carMake = string.Empty;
                        string carModel = string.Empty;
                        decimal carPrice = 0.00M;
                        string carColor = string.Empty;
                        bool is4wheeler = false;

                        Console.WriteLine("What is the car make?");
                        carMake = Console.ReadLine();
                        Console.WriteLine("What is the car model?");
                        carModel = Console.ReadLine();
                        Console.WriteLine("What is the car price?");
                        try
                        {
                            carPrice = decimal.Parse(Console.ReadLine());
                        }
                        catch (Exception) 
                        {
                            Console.WriteLine("Please enter a valid number");
                            while (!decimal.TryParse(Console.ReadLine(),out carPrice))
                            {
                                Console.WriteLine("Please enter a valid number");
                            }

                        }
                        
                        Console.WriteLine("What is the color?");
                        carColor = Console.ReadLine();
                        Console.WriteLine("The car is a 4 wheeler? ");
                        try
                        {
                            is4wheeler = bool.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please type true or false");
                            while (!bool.TryParse(Console.ReadLine(),out is4wheeler))
                            {
                                Console.WriteLine("Please type true or false");
                            }
                            
                        }


                        Car newCar = new Car(carMake, carModel, carPrice, carColor,is4wheeler);
                        s.CarList.Add(newCar);

                        printInventory(s);

                        break;

                    // Add to cart
                    case 2:
                        Console.WriteLine("You  choose to add a car to your shopping cart");
                        printInventory(s);
                        Console.WriteLine("Wich item woulkd you like to buy? (number)");
                        int carChosen;
                        try
                        {
                            carChosen = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid number");
                            while (int.TryParse(Console.ReadLine(),out carChosen))
                            {
                                Console.WriteLine("Please enter a valid number");
                            }
                            
                        }


                        try
                        {
                            s.ShoppingList.Add(s.CarList[carChosen]);
                        }
                        catch (Exception)
                        {
                            

                                Console.WriteLine("There is no car for this number");

                        }
                       

                        printShoppingCart(s);
                        break;


                    case 3:

                        printShoppingCart(s);
                        Console.WriteLine($"The total cost of your items is :  {s.Checkout()}");

                        break;

                    default:
                        break;
                }

                action = chooseAction();
            }

   

        }

        private static void printShoppingCart(Store s)
        {

            Console.WriteLine("Cars you have chosen to buy.");
            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine($"Car # {i} : {s.ShoppingList[i]}");
            }
        }

        private static void printInventory(Store s)
        {
            for (int i = 0; i < s.CarList.Count; i++)
            {
                Console.WriteLine($"Car # {i} : {s.CarList[i]}");
            } 

        }

        public static int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new car to inventory (2) add car to cart (3) checkout");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                
                Console.WriteLine("Please type a valid number between 0 and 3");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please type a valid number");


                }

            }

            return choice;



        }
    }
}
