using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Lab_16_Countries
{
    public class Validator
    {
        public static bool CountryValidator(string country)
        {


                
                string validatorPath = @"ListOfAllCountries.txt";
                List<string> worldCountries = File.ReadAllLines(validatorPath).ToList();
                foreach (string x in worldCountries)
                {
                    if (x.ToLower().Contains(country.Trim())) 
                    {
                        return true;
                    }
                }
            return false;

        }
    }
}
