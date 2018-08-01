using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_16_Countries
{
    class CountriesTextFile
    {
        public static void CountryWriter()
        {
            string path = @"C:\Users\GC Student\Documents\Temp\countries.txt";
            Console.WriteLine("Enter a valid country:");
            string country = Console.ReadLine().ToLower();
            if (Validator.CountryValidator(country))
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(country);
                    }
                }
                else
                {
                    File.AppendAllText(path, country);
                }
            }
            else
            {
                Console.WriteLine("Not a valid Country.");
            }

            
        }
        public static void CountryReader()
        {
            string path = @"C:\Users\GC Student\Documents\Temp\countries.txt";
            try
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch
            {
                Console.WriteLine("The file of countries does not exist.");
            }
        }
        public static void CountryDeleter()
        {
            string path = @"C:\Users\GC Student\Documents\Temp\countries.txt";
            List<string> countryList = File.ReadAllLines(path).ToList();
            Console.WriteLine("Which country would you like to delete? (# in list)");
            int delete = int.Parse(Console.ReadLine());
            countryList.RemoveAt(delete-1);
            File.WriteAllLines(path, countryList.ToArray());
        }
    }
}
