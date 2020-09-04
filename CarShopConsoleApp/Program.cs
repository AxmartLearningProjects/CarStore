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

            Console.WriteLine("Welcome to the car store. First You must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout wich will give you a total value of the shopping cart.");


            int action = chooseAction();
            while (action != 0)
            {
                Console.WriteLine($"You chose {action}");
               action = chooseAction();
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
