using BrandmuscleAutomation.StartUp;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandmuscleAutomation.Interactions
{
    static class Element
    {
        internal static IWebElement getElement(this By by)
        {
            return Base.Driver.FindElement(by);
        }

        internal static IWebElement getElement(this By by, int waittimeinsecs)
        {
            by.WaitExists(waittimeinsecs);
            return Base.Driver.FindElement(by);
        }
        internal static IList<IWebElement> getElements(this By by)
        {
            return Base.Driver.FindElements(by);
        }

        internal static IList<IWebElement> getElements(this By by, int waittimeinsecs)
        {
            by.WaitExists(waittimeinsecs);
            return Base.Driver.FindElements(by);
        }
        internal static bool IsElementDisplayed(this By by)
        {
            try
            {
                bool displayed = Base.Driver.FindElement(by).Displayed;

                return displayed;
            }
            catch
            {
                throw new Exception("ELEMENTNOTDISPLAYED");
                // throw new System.Exception("ELEMENTNOTDISPLAYED");
            }
        }
        // Element is enabled or not
        internal static bool IsElementEnabled(this By by)
        {
            try
            {
                bool enabled = Base.Driver.FindElement(by).Enabled;

                return enabled;
            }
            catch
            {
                throw new Exception("ELEMENTNOTENABLED");
            }
        }
        //Element is selected or not
        internal static bool IsElementSelected(this By by)
        {

            try
            {
                bool selected = Base.Driver.FindElement(by).Selected;
                return selected;
            }
            catch
            {
                throw new Exception("ELEMENTNOTSELECTED");
            }

        }
    }
}
