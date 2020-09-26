using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace miniArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Console.WriteLine("What is your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Choose 1, 2, or 3: ");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "Bolt" : "Banana";
            Console.WriteLine("Hey {0}! You entered {1}, therefore you have won {2}", userName, userValue, message);
            Console.ReadLine();
            */
            /*
            int[] numbers = new int[5];
            numbers[0] = 3;
            numbers[1] = 14;
            // Console.WriteLine(numbers[1]);
            numbers[5] = 24;
            Console.WriteLine(numbers.Length);
            */
            /*
            int[] numbers = new int[] {4,5,68,2,43,45,83};
            Console.WriteLine(numbers.Length);
            Console.WriteLine("Welcome! You are number {0}", numbers[5]);
            */
            // string[] names = new string[] { "Tade", "Mide", "Omolabake" };
            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            // Console.WriteLine(names[0]);
            
            */
            /*
            foreach (string oruko in names)
            {
                Console.WriteLine(oruko);
            }
            */
            // Flipping words in a sentence.

            /*
            string zig = "You can be good " + "You are already good.";
            char[] orukoArray = zig.ToCharArray();
            Array.Reverse(orukoArray);
            foreach (char zigchar in orukoArray)
            {
                Console.Write(zigchar);
            }
            //Console.Write
            Console.ReadLine();
            */

            // Methods
            Console.WriteLine("What is the name of your city: ");
            string userCity = Console.ReadLine();
            string reversedCity = ReverseString(userCity);

            Console.WriteLine("And your favorite sport? ");
            string userFavSport = Console.ReadLine();
            string reversedFavSport = ReverseString(userFavSport);

            Console.Write("Results: ");
            PrintString(reversedCity);
            PrintString(reversedFavSport);

            Console.Write("Results: ");
            PrintString(reversedCity, reversedFavSport);
            // string messageToReverse = userCity + " " + userFavSport;
            // ReverseString(messageToReverse);
            Console.ReadLine();

        }
        /*
        private static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        */

        private static string ReverseString(string message)
        {
            
            char[] orukoArray = message.ToCharArray();
            Array.Reverse(orukoArray);
            return String.Concat(orukoArray);
        }

        private static void PrintString(string message)
        {
            Console.Write(message);
            /*
            foreach (char omoChar in orukoArray)
            {
                Console.Write(omoChar);
            }
            */
            //To have a space after each call result:
            Console.Write(" ");

        }
        public static void PrintString(string reversedCity, string reversedFavSport)
        {
            Console.Write(reversedCity + " " + reversedFavSport);
        }
    }
}
