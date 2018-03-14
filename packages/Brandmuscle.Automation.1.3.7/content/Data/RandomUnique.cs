using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrandmuscleAutomation.Enum;

namespace BrandmuscleAutomation.Data
{
    static class RandomUnique
    {
        internal static void Address(States state)
        {
            // Address1
            // Address2
            // State
            // City
            // Zip
        }

        internal static string UniqueLocationName(string locationname)
        {
            string timeStamp = DateTime.Now.ToString();
            timeStamp = timeStamp.Replace("/", "").Replace(" ", "").Replace(":", "");
            return locationname + timeStamp;
        }
        internal static string UniqueName(string name)
        {
            string timeStamp = DateTime.Now.ToString();
            timeStamp = timeStamp.Replace("/", "").Replace(" ", "").Replace(":", "");
            return name + timeStamp;
        }
    }
}
