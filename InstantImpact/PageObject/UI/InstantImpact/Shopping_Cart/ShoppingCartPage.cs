using System;
using BrandmuscleAutomation.StartUp;
using log4net;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using BrandmuscleAutomation.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace InstantImpact.PageObject.UI.InstantImpact.Shopping_Cart
{
    class ShoppingCartPage : Base
    {
        public static ExtentTest test;
        public static By ShoppinCartHeader
        { get { return (By.XPath("//*[@id='shopCartHeader']")); } }

        public static void VerifyShoppingCartPage()
        {   
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(ShoppingCartPage));
            try
            {
                bool status_of_header = ShoppinCartHeader.IsElementDisplayed();
                Console.WriteLine("Status of Shopping Cart Header is " + status_of_header);
                Assert.IsTrue(status_of_header);
            }
            catch(Exception e)
            {
                logger.Error("Verify Shopping Cart Page failed due to: " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }
    }
}
