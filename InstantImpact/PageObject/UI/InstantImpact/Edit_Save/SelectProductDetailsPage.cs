using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Interactions;
using log4net;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.PageObject.UI.InstantImpact.EditButton
{
    class SelectProductDetailsPage : Base
    {
        public static ExtentTest test;
        public static By SelectProductDetailsHeader
        {get { return (By.XPath("//h1[contains(text(),'Select Product Details')]")); } }

        public static By Cancel
        { get { return (By.Id("Body_lnkBtnCancel")); } }

        public static By Frame
        { get { return (By.XPath("//*[contains(@id,'confirm1520')]")); } }

        public static By FrameYes
        { get { return (By.XPath("//*[@class='btn GenericRedButton'][3]")); } }

        public static By SearchHeader
        { get { return (By.Id("Body_lblSearchHeader"));} }

        public static void VerifySelectDetailsPage()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(SelectProductDetailsPage));
            test = extent.CreateTest("VerifySelectDetailsPage");
            try
            {
                Wait.WaitVisible(SelectProductDetailsHeader, 30);
                bool status = SelectProductDetailsHeader.IsElementDisplayed();
                Console.WriteLine("Status of Produvt Deatils Header is " + status);
                logger.Info("Status of Product Deatils Header is ." + status);
            }
            catch(Exception e)
            {
                logger.Error("Verify Select Product page failed due to : " + e);
                test.Fail("Verify Select Product page failed.");
                //**Closing browser
                Driver.Quit();
            }
        }

        //Cancel
        public static void CancelSelectProductDetails()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(SelectProductDetailsPage));
            test = extent.CreateTest("CancelSelectProductDetails");
            try
            {
                Cancel.Click();
                Switches.SwitchToIFrame(Frame);
                FrameYes.Click();
                Wait.WaitVisible(SearchHeader, 30);
                String actual_title = Driver.Title;
                Assert.IsTrue(actual_title.Contains("Item Search"), actual_title + "Error msg -After clicking on Cancel Item Search page is not comming");
            }
            catch(Exception e)
            {
                logger.Error("Cancel Select Product Details failed due to : " + e);
                test.Fail("Cancel Select Product Details failed.");
                //**Closing browser
                Driver.Quit();
            }
        }

    }
}
