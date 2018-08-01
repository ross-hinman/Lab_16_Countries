using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_16_Countries
{
    class CountriesApp
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome to the Countries Maintenance Application!\n1 - See the list of countries\n2 - Add a country\n3 - Delete a country\n4 - Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CountriesTextFile.CountryReader();
                        break;
                    case "2":
                        CountriesTextFile.CountryWriter();
                        break;
                    case "3":
                        CountriesTextFile.CountryDeleter();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        repeat = false;
                        break;
                }
            } while (repeat == true);
        }
    }
}
