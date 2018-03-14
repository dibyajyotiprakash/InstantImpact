using BrandmuscleAutomation.StartUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrandmuscleAutomation.Interactions
{
    static class Wait
    {
        internal static void WaitExists(this By by, int timeOut = 120)
        {
            new WebDriverWait(Base.Driver, TimeSpan.FromSeconds(timeOut)).Until(ExpectedConditions.ElementExists(by));
        }

        internal static void WaitVisible(this By by, int timeOut = 60)
        {
           
            new WebDriverWait(Base.Driver, TimeSpan.FromSeconds(timeOut)).Until(ExpectedConditions.ElementIsVisible(by));
        }

        internal static bool IsWaitVisible(this By by, int timeOut = 60)
        {
            try
            {
                new WebDriverWait(Base.Driver, TimeSpan.FromSeconds(timeOut)).Until(ExpectedConditions.ElementIsVisible(by));
                return true;
            }
            catch
            {
                // do not need to catch exception
                return false;
            }
            
        }

        internal static void WaitWhileNotVisible(this By by)
        {
            var stillExists = true;
            while (stillExists)
            {
                try
                {
                    WaitVisible(by, 1);
                }
                catch
                {
                    stillExists = false;
                }
                
            }
        }

        public static void WaitTime(int seconds)
        {
            try{seconds = seconds * 1000;}catch{seconds = 1000;}
            Thread.Sleep(seconds);
        }

        public static void WaitForPageToLoad()
        {
            IWait<IWebDriver> wait = new WebDriverWait(Base.Driver, TimeSpan.FromSeconds(30.00));
            wait.Until(driver1 => ((IJavaScriptExecutor)Base.Driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public static void WaitForPageToLoad(int timeinsec)
        {
            IWait<IWebDriver> wait = new WebDriverWait(Base.Driver, TimeSpan.FromSeconds(timeinsec + .00));
            wait.Until(driver1 => ((IJavaScriptExecutor)Base.Driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
       
    }
}
