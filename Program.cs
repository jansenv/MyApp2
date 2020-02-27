using System;
using System.Collections.Generic;

namespace MyApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!";
            int numberOfTacos = 10;
            bool hasMeat = false;
            List<string> names = new List<string>() { "Adam", "Brenda", "Rose" };

            // for loops
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            // foreach loops
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(message);
            Console.WriteLine(numberOfTacos);
            Console.WriteLine(hasMeat);
            Console.WriteLine(message + " " + "I'd like " + numberOfTacos + " tacos. Meat? " + hasMeat);
            Console.WriteLine($"{message} I'd like {numberOfTacos} tacos. Meat? {hasMeat}");

            if (numberOfTacos > 5)
            {
                Console.WriteLine("Oh boy, that's a lotta tacos");
            }
            else if (numberOfTacos < 3)
            {
                Console.WriteLine("Level up your taco game");
            }
            else
            {
                Console.WriteLine("Sounds like a good number o' tacos");
            }
        }
    }
}
