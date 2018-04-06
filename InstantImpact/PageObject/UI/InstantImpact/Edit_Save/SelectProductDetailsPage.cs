using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Interactions;
using log4net;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.PageObject.UI.InstantImpact.Edit_Save
{
    class SelectProductDetailsPage : Base
    {
        public static ExtentTest test;
        public static By SelectProductDetailsHeader
        {get { return (By.XPath("//*[text()='Select Product Details'][1]")); } }

        public static By Cancel
        { get { return (By.Id("Body_lnkBtnCancel")); } }

        public static By Frame
        { get { return (By.XPath("//*[@class='rwWindowContent']")); } }

        public static By FrameYes
        { get { return (By.XPath("//*[@class='boxes']/a[1]")); } }

        public static By SearchHeader
        { get { return (By.Id("Body_lblSearchHeader"));} }

        public static By Back
        { get { return (By.XPath("//*[@id='Body_lnkBtnCancel']")); } }

        public static By Yes
        { get { return (By.XPath("//*[@class='boxes']/a[1]")); } }
        

        public static void VerifySelectProductDetailsPage()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(SelectProductDetailsPage));
            try
            {
                Wait.WaitForPageToLoad();
                Wait.WaitVisible(SelectProductDetailsHeader,30);
                bool status = SelectProductDetailsHeader.IsElementDisplayed();
                Console.WriteLine("Status of Product Deatils Header is " + status);
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
            try
            {
                Cancel.Click();
                Wait.WaitVisible(FrameYes, 10);
                FrameYes.Click();
            }
            catch(Exception e)
            {
                logger.Error("Cancel Select Product Details failed due to : " + e);
                test.Fail("Cancel Select Product Details failed.");
                //**Closing browser
                Driver.Quit();
            }
        }

        //Click on Back
        public static void ClickOnBack()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(SelectProductDetailsPage));
            try
            {
                Wait.WaitVisible(Back);
                Back.Click();
            }
            catch (Exception e)
            {
                logger.Error("Click on back failed due to : " + e);
                test.Fail("Click on back failed.");
                //**Closing browser
                Driver.Quit();
            }
        }

        //Click on Yes From Back
        public static void ClickYesFromBack()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(SelectProductDetailsPage));
            try
            {
                Wait.WaitVisible(Yes);
                Yes.Click();
            }
            catch (Exception e)
            {
                logger.Error("Click on yes from back failed due to : " + e);
                test.Fail("Click on yes from back failed.");
                //**Closing browser
                Driver.Quit();
            }
        }

    }
}
