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

            Car c = new Car();
            Car d = new Car("Ford", "Mustang", 9200);

            Console.WriteLine($"Car c is as follows : {c.Make}\t{c.Model}\t{c.Price}");
            Console.WriteLine($"Car c is as follows : {d.Make}\t{d.Model}\t{d.Price}");


            


            Console.ReadKey();

        }
    }
}
