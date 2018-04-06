using System;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Interactions;
using log4net;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AventStack.ExtentReports;


namespace InstantImpact.PageObject.UI.InstantImpact.OverwriteSavePrompt
{
    class POS_On_Demand : Base
    {
        public static ExtentTest test;
        public static By MyProject
        { get { return (By.XPath("//*[@href='/Account/MyProjectsPage.aspx']")); } }

        public static By AnyTemplate
        { get { return (By.XPath("//*[@href='/POS/ItemDetails.aspx?tid=114916']")); } }

        public static By CreateYourDesign
        { get { return (By.XPath("//*[@id='Body_btnProductDesign']")); } }

        public static By SearchTemplate
        { get { return (By.XPath("//*[@id='Body_txtSearch']")); } }

        public static By PosOnDemandHeader
        { get { return (By.XPath("//*[text()='POS On Demand'][3]")); } }

        
        //Click on any Template
        public static void SelectTemplate()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(POS_On_Demand));
            try
            {
                AnyTemplate.Click();
                Clicks.ScrollToViewElement(CreateYourDesign);
                Wait.WaitVisible(CreateYourDesign, 10);
                CreateYourDesign.Click();
            }
            catch (Exception e)
            {
                logger.Error("Pos on demand failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Verify Pos On Demand
        public static void VerifyPosOnDemand()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(POS_On_Demand));
            try
            {
                Wait.WaitVisible(PosOnDemandHeader);
                bool status_of_posheader = PosOnDemandHeader.IsElementDisplayed();
                Assert.IsTrue(status_of_posheader);
            }
            catch(Exception e)
            {
                logger.Error("Pos on demand failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }
    }
}
