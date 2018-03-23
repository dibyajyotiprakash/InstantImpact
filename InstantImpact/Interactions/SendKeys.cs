using BrandmuscleAutomation.StartUp;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandmuscleAutomation.Interactions
{
    static class SendKeys
    {
        internal static void Type(this By by, string value)
        {
            Base.Driver.FindElement(by).SendKeys(value);
        }
        internal static void Type(this By by, string value, int waittimeinsecs)
        {
            by.WaitExists(waittimeinsecs);
            Base.Driver.FindElement(by).SendKeys(value);
        }
        internal static void Clear(this By by)
        {
            Base.Driver.FindElement(by).Clear();
        }
        internal static void Clear(this By by, int waittimeinsecs)
        {
            by.WaitExists(waittimeinsecs);
            Base.Driver.FindElement(by).Clear();
        }
        internal static void TypeClear(this By by, string value)
        {
            var element = Base.Driver.FindElement(by);
            element.Clear();
            element.SendKeys(value);
        }
        internal static void TypeClear(this By by, string value, int waittimeinsecs)
        {
            by.WaitExists(waittimeinsecs);
            var element = Base.Driver.FindElement(by);
            element.Clear();
            element.SendKeys(value);
        }

        internal static void SelectTextAndType(this By by, string value)
        {
            Base.Driver.FindElement(by).SendKeys(Keys.Control + "a");
            Base.Driver.FindElement(by).SendKeys(value);
        }
        internal static void CopyData(this By by)
        {
            Base.Driver.FindElement(by).SendKeys(Keys.Control + "a");
            Base.Driver.FindElement(by).SendKeys(Keys.Control + "c");
        }

        internal static void PasteData(this By by)
        {
            Base.Driver.FindElement(by).SendKeys(Keys.Control + "v");
        }

    }
}
