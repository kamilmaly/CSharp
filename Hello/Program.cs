using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ; )
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int mixInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + mixInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
            Console.WriteLine("maxDouble = " + maxDouble);
            Console.WriteLine("minDouble = " + minDouble);
            Console.WriteLine("maxFloat = " + maxFloat);
            Console.WriteLine("minFloat = " + minFloat);
        }

        /// <summary>
        /// Settings
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Print the message according to age
        /// </summary>
        private static void Age()
        {
            Console.WriteLine("How old are you ?");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("You are " + age + " years old");

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations! You are of legal age. You can drink beer.");
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error enter age!");
            }
            else
            {
                Console.WriteLine("We can offer you milk.");
            }
        }
        /// <summary>
        /// Prints the user greeting
        /// </summary>
        private static void Greeting()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
