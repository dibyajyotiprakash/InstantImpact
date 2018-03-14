using BrandmuscleAutomation.StartUp;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandmuscleAutomation.Interactions
{
    static class Checks
    {
        internal static void Check(this By by)
        {
            if (!by.getElement().Selected)
            {
                Base.Driver.FindElement(by).Click();
            }
            
        }
        internal static void Check(this By by, int timeinsecs)
        {
            by.WaitExists(timeinsecs);
            if (!by.getElement().Selected)
            {
                Base.Driver.FindElement(by).Click();
            }
        }
        internal static void CheckJavaScript(this By by)
        {
            if (!by.getElement().Selected)
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)Base.Driver;
                executor.ExecuteScript("arguments[0].click();", by.getElement());
            }
            
        }
        internal static void CheckJavaScript(this By by, int timeinsecs)
        {
            by.WaitExists(timeinsecs);
            if (!by.getElement().Selected)
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)Base.Driver;
                executor.ExecuteScript("arguments[0].click();", by.getElement());
            }
        }
        internal static void Uncheck(this By by)
        {
            if (by.getElement().Selected)
            {
                Base.Driver.FindElement(by).Click();
            }

        }
        internal static void Uncheck(this By by, int timeinsecs)
        {
            by.WaitExists(timeinsecs);
            if (by.getElement().Selected)
            {
                Base.Driver.FindElement(by).Click();
            }
        }
        internal static void UncheckJavaScript(this By by)
        {
            if (by.getElement().Selected)
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)Base.Driver;
                executor.ExecuteScript("arguments[0].click();", by.getElement());
            }

        }
        internal static void UncheckJavaScript(this By by, int timeinsecs)
        {
            by.WaitExists(timeinsecs);
            if (by.getElement().Selected)
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)Base.Driver;
                executor.ExecuteScript("arguments[0].click();", by.getElement());
            }
        }

        internal static void CheckAndReCheck(this By by, By ElementToCheck)
        {
            if (!by.getElement().Selected)
            {
                Base.Driver.FindElement(by).Click();
            }

            Wait.WaitTime(1);
            if (!ElementToCheck.IsElementPresent() || !by.getElement().Selected)
            {
                Base.Driver.FindElement(by).Click();
            }

        }
        internal static void CheckAndReCheck(this By by, By ElementToCheck, int timeinsecs)
        {
            by.WaitExists(timeinsecs);
            if (!by.getElement().Selected)
            {
                Base.Driver.FindElement(by).Click();
            }

            Wait.WaitTime(1);
            if (!ElementToCheck.IsElementPresent() || !by.getElement().Selected)
            {
                Base.Driver.FindElement(by).Click();
            }
        }
    }
}
