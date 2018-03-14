using BrandmuscleAutomation.StartUp;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandmuscleAutomation.Interactions
{
    static class Navigation
    {
        internal static void GoToURL(this string url)
        {
            Base.Driver.Navigate().GoToUrl(url);
        }
        internal static void Refresh()
        {
            Base.Driver.Navigate().Refresh();
        }
        internal static void ScrollBy(int scroll)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Base.Driver;
            js.ExecuteScript(" window.scrollBy(0, scroll);");

        }
    }
}
