﻿using System.Collections.Specialized;

namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. Print all numbers");
                Console.WriteLine("2. Add a new number");
                Console.WriteLine("3. Remove number");
                Console.WriteLine("4. Quit");
                Console.ResetColor();
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        printAllNums(phonebook);
                        break;
                    case 2:
                        addNewNum(phonebook);
                        break;
                    case 3:
                        removeNum(phonebook);
                        break;
                    default:
                        break;
                }
                if (input == 4)
                    break;
            }
        }

        private static void removeNum(Dictionary<string, string> phonebook)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter the person's name who's phone number you want to remove");
            Console.ResetColor();
            string name = Console.ReadLine();
            if (phonebook.ContainsKey(name))
                phonebook.Remove(name);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Couldn't find {name} in your phonebook");
                Console.ResetColor();
                removeNum(phonebook);
            }
        }

        private static void addNewNum(Dictionary<string, string> phonebook)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Name:");
            Console.ResetColor();
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Phone number:");
            Console.ResetColor();
            string phoneNum = Console.ReadLine();
            phonebook.Add(name, phoneNum);

        }

        private static void printAllNums(Dictionary<string, string> phonebook)
        {
            if (phonebook.Count == 0)
            {
                Console.WriteLine("The phonebook is empty");
                Console.WriteLine();
                return;
            }

            foreach (KeyValuePair<string, string> kvp in phonebook)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} ");
            }
        }
    }
}

