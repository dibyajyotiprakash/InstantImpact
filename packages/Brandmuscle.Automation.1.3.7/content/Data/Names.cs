using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNameGenerator;

namespace BrandmuscleAutomation.Data
{
    public class Names
    {
        public static string FirstName = NameGenerator.GenerateFirstName(Gender.Female);
        public static string LastName = NameGenerator.GenerateLastName();
    }
}
