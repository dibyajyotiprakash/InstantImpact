using BrandmuscleAutomation.StartUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace BrandmuscleAutomation.Interactions
{
     static class Alerts
    {
        internal static bool AcceptAlert()
        {
            try
            {
                var driver = Base.Driver;
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
                Console.Out.WriteLine("Alert Was Present");
                return true;
            }
            catch
            {
                Console.Out.WriteLine("No Alert Found");
                return false;
            }
            
        }
    }
}
