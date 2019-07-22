using System;
using System.Linq;
using System.Net.WebSockets;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
        }

        private static void Exercise1()
        {
            var people = new People {Name = "Marry", Gender = true, Age = 25};
            Console.WriteLine("Simple Properties Demo");
            Console.WriteLine("Person details: " + people.ToString());
            people.Age = 35;
            Console.WriteLine("Person details (apter incrementing age): " + people.ToString());
        }

        private static void Exercise2()
        {
            Console.WriteLine("Enter a String:");
            var inputStr = Console.ReadLine();
            Console.WriteLine("Enter a word to search:");
            var wordToSearch = Console.ReadLine();

            var count = Regex.Matches(inputStr, wordToSearch).Count;

            Console.WriteLine($"Word found {count} times in the string");
        }
    }
}