using BrandmuscleAutomation.StartUp;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandmuscleAutomation.Interactions
{
    static class Get
    {
        internal static string GetText(this By by)
        {
            return Base.Driver.FindElement(by).Text;
        }
        internal static string GetText(this By by, int waittimeinsecs)
        {
            by.WaitExists(waittimeinsecs);
            return Base.Driver.FindElement(by).Text;
        }
        internal static void Windowhandle()
        {
            Base.Driver.SwitchTo().Window(Base.Driver.WindowHandles.Last());
            Wait.WaitTime(15);
            Base.Driver.Close();
            Base.Driver.SwitchTo().Window(Base.Driver.WindowHandles.First());


        }
        internal static string GetCurrentURL()
        {
            return Base.Driver.Url;
        }
        internal static string GetTextJavaScript(this By by)
        {
            return ((IJavaScriptExecutor)Base.Driver).ExecuteScript("return $(arguments[0]).text();", Base.Driver.FindElement(by)).ToString();
        }
        internal static string GetTextJavaScript(this By by, int waittimeinsecs)
        {
            by.WaitExists(waittimeinsecs);
            return ((IJavaScriptExecutor)Base.Driver).ExecuteScript("return $(arguments[0]).text();", Base.Driver.FindElement(by)).ToString();
        }
    }
}
