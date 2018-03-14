using BrandmuscleAutomation.StartUp;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandmuscleAutomation.Interactions
{
    static class Exists
    {
        internal static bool IsElementPresent(this By by)
        {
            try
            {
                Base.Driver.FindElement(by);
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal static bool IsElementPresent(this By by, int waittimeinsecs)
        {
            try
            {
                by.WaitExists(waittimeinsecs);
                Base.Driver.FindElement(by);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
