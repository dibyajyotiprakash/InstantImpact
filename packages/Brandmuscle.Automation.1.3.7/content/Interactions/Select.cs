using BrandmuscleAutomation.StartUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandmuscleAutomation.Interactions
{
    static class Select
    {
        internal static void SelectByText(this By by, string text)
        {
            new SelectElement(Base.Driver.FindElement(by)).SelectByText(text);
        }
        internal static void SelectByText(this By by, string text, int waititmeinsecs)
        {
            by.WaitExists(waititmeinsecs);
            new SelectElement(Base.Driver.FindElement(by)).SelectByText(text);
        }
        internal static void SelectByValue(this By by, string value)
        {
            new SelectElement(Base.Driver.FindElement(by)).SelectByValue(value);
        }
        internal static void SelectByValue(this By by, string value, int waititmeinsecs)
        {
            by.WaitExists(waititmeinsecs);
            new SelectElement(Base.Driver.FindElement(by)).SelectByValue(value);
        }
        internal static void SelectByIndex(this By by, int index)
        {
            new SelectElement(Base.Driver.FindElement(by)).SelectByIndex(index);
        }
        internal static void SelectByIndex(this By by, int index, int waititmeinsecs)
        {
            by.WaitExists(waititmeinsecs);
            new SelectElement(Base.Driver.FindElement(by)).SelectByIndex(index);
        }
    }
}
