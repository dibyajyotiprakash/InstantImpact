using BrandmuscleAutomation.StartUp;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandmuscleAutomation.Interactions
{
    static class Switches
    {
        internal static void SwitchToIFrame(this By by)
        {
            Base.Driver.SwitchTo().Frame(by.getElement());
        }
              
        internal static void SwitchToIFrame(this By by, int timeinsecs)
        {
            by.WaitExists(timeinsecs);
            Base.Driver.SwitchTo().Frame(by.getElement());
        }
        internal static IWebDriver IFrameDriver(this By by)
        {
            IWebDriver driver = Base.Driver;
            driver.SwitchTo().Frame(by.getElement());
            return driver;
        }
        internal static IWebDriver IFrameDriver(this By by, int timeinsecs)
        {
            by.WaitExists(timeinsecs);
            IWebDriver driver = Base.Driver;
            driver.SwitchTo().Frame(by.getElement());
            return driver;
        }
        internal static void SwitchDriverToDefault()
        {
            Base.Driver.SwitchTo().Window(Base.CurrentWindow);
        }
        internal static void SwitchToNewBrowserTab()
        {
            Base.Driver.SwitchTo().Window(Base.Driver.WindowHandles.Last());
        }
    }
}
