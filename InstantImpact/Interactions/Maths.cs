using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandmuscleAutomation.Interactions
{
    static class Maths
    {
        public static decimal ConvertToDecimalFromDollarString(this string value)
        {
            return Convert.ToDecimal(value.Substring(1, value.Length - 1));
        }

        public static decimal RoundToTwoDecimal(this decimal value)
        {
            return Math.Round(value, 2);
        }

        public static string ConvertToDollarValueWithDollarSign(this decimal value)
        {
            return "$" + Convert.ToString(value.RoundToTwoDecimal());
        }
    }
}
