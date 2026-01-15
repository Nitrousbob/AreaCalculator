using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator4
{
    public static class Validators
    {
        public static bool IsMinimumLength(string value, int min)
        {
            return value.Length >= min;
        }
    }
}
