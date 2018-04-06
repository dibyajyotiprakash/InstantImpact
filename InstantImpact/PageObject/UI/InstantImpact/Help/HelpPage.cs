using System;
using log4net;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.PageObject.UI.InstantImpact.Help
{
    class HelpPage : Base
    {
        public static ExtentTest test;

        public static By HelpHeader
        { get { return (By.XPath("//*[text()='Help'][2]")); } }

        public static By TrainingGuide
        { get { return (By.XPath("//*[@href='/iiassets/44/Documents/Instant Impact 4.0 Training Guide.pdf']")); } }

        //Verify Help Page
        public static void VerifyHelpPage()
        {        
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(HelpPage));
            try
            {
                Wait.WaitForPageToLoad();
                Wait.WaitVisible(HelpHeader);
                bool status_of_helpheder = HelpHeader.IsElementDisplayed();
                Console.WriteLine("Status of Help Header is " + status_of_helpheder);
                Assert.IsTrue(status_of_helpheder.Equals(true), status_of_helpheder + "Error msg -Help Header is not displaying");
            }
            catch (Exception e)
            {
                logger.Error("Verify Help Page failed due to: " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on Training Guides
        public static void ClickOnTrainingGudes()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(HelpPage));
            try
            {
                Wait.WaitForPageToLoad();
                Wait.WaitVisible(TrainingGuide);
                TrainingGuide.Click();
            }
            catch (Exception e)
            {
                logger.Error("Click on Training guide failed due to: " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }


        }
    }
}
