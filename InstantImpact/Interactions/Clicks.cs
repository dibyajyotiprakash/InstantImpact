using BrandmuscleAutomation.StartUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandmuscleAutomation.Interactions
{
    static class Clicks
    {
        internal static void Click(this By by)
        {
            Base.Driver.FindElement(by).Click();
        }
        internal static void Click(this By by, int timeinsecs)
        {
            by.WaitExists(timeinsecs);
            Base.Driver.FindElement(by).Click();
        }
        internal static void HoverBy(this By Hoverby)
        {
            IWebElement elementToHover = Base.Driver.FindElement(Hoverby);
            Actions hover = new Actions(Base.Driver);
            hover.MoveToElement(elementToHover);
            Wait.WaitTime(1);
            hover.Perform();
            Wait.WaitTime(3);
        }
        public static void HoverByJavaScript(this By Hoverby)
        {
            string javaScript = "var evObj = document.createEvent('MouseEvents');" +
                    "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);" +
                    "arguments[0].dispatchEvent(evObj);";
            IJavaScriptExecutor executor = Base.Driver as IJavaScriptExecutor;
            executor.ExecuteScript(javaScript, Hoverby.getElement());
        }
        internal static void HoverByClickBy(this By Hoverby, By ClickBy)
        {
            IWebElement elementToHover = Base.Driver.FindElement(Hoverby);
            Actions hover = new Actions(Base.Driver);
            hover.MoveToElement(elementToHover);
            hover.Perform();
            Wait.WaitTime(1);
            ClickBy.WaitVisible(10);
            Click(ClickBy);
        }
        internal static void HoverByClickBy(this By Hoverby, By ClickBy, int timeinsecs)
        {
            Hoverby.WaitExists(timeinsecs);
            IWebElement elementToHover = Base.Driver.FindElement(Hoverby);
            Actions hover = new Actions(Base.Driver);
            hover.MoveToElement(elementToHover);
            hover.Perform();
            Click(ClickBy);
        }
        internal static void HoverClickBy(this By by)
        {
            IWebElement elementToHover = Base.Driver.FindElement(by);
            Actions hover = new Actions(Base.Driver);
            hover.MoveToElement(elementToHover);
            hover.Perform();
            Click(by);
        }
        internal static void HoverClickBy(this By by, int timeinsecs)
        {
            by.WaitExists(timeinsecs);
            IWebElement elementToHover = Base.Driver.FindElement(by);
            Actions hover = new Actions(Base.Driver);
            hover.MoveToElement(elementToHover);
            hover.Perform();
            Click(by);
        }
        internal static void ClickJavaScript(this By by)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Base.Driver;
            executor.ExecuteScript("arguments[0].click();", by.getElement());
        }
        internal static void ClickJavaScript(this By by, int timeinsecs)
        {
            by.WaitExists(timeinsecs);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Base.Driver;
            executor.ExecuteScript("arguments[0].click();", by.getElement());
        }

        // Scroll the page untill the element is in the view
        //For Any clearity please contact Rahul Jangwan and KavinKumar
        public static void ScrollToViewElement(this By by)
        {
            IWebElement element = Base.Driver.FindElement(by);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Base.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        //For Any clearity please contact Rahul Jangwan and KavinKumar
        public static void ScrollToViewElement(this IWebElement element)
        {
            //IWebElement element = Core.Driver.FindElement(by);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Base.Driver;
            js.ExecuteScript("arguments[0].scrolSlIntoView(true);", element);
        }
    }
}
