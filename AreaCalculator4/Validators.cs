using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator4
{
    public static class Validators
    {
        public static bool IsMinimumLength(string value, int min)  //needs to be static to be called without creating an instance of the class
        {
            return value.Length >= min;
        }

        public static bool ContainsInteger(string value, out int number)
        {
            return int.TryParse(value, out number);
        }
    }
}
