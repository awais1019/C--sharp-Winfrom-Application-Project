using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Login.UI
{
    class Validations
    {
        public static bool validate(string input)
        {
            string pattern = @"^[\w ]{4,12}$";
            return Regex.IsMatch(input, pattern);
        }
    }
}
