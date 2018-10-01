using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkSentinelWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            // Centinel While Loop

            // Read data from Console'
            Console.WriteLine("Enter number or otherwise  quit the program");
            string input = Console.ReadLine();  
            while (input != "quit")
            {
                Random rand = new Random();
                int value = rand.Next(int.Parse(input));
                Console.WriteLine($"Result-{value}");

                Console.WriteLine("If you would to continue your loop: then enter number other use quit the program");
                input = Console.ReadLine();
            }

            Console.WriteLine("Now the while loop is terminated");

            Console.ReadKey();




        }
    }
}
