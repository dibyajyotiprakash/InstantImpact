using System;
using BrandmuscleAutomation.StartUp;
using log4net;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using BrandmuscleAutomation.Interactions;

namespace InstantImpact.PageObject.UI.InstantImpact.Gmail
{
    class LoginGmailPageMail : Base
    {
        public static ExtentTest test;
        public static By UserName
        { get { return (By.XPath("//*[@name='identifier']")); } }

        public static By Next
        { get { return (By.XPath("//*[text()='Next']")); }}

        public static By Password
        { get { return (By.XPath("//*[@name='password']")); } }

        public static By MailBySender
        { get { return (By.XPath("//*[@class='yX xY ']/div[2]/span[text()='brandmuscle'][1]")); } }

        public static By Link
        { get { return (By.XPath("//*[text()='Click here to view the design']")); } }


        //Login to Gmail
        public static void LoginToGmail(string un,string pwd)
        {      
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(LoginGmailPageMail));
            try
            {
                UserName.Type(un);
                Wait.WaitVisible(Next,10);
                Next.Click();
                Wait.WaitVisible(Password, 10);
                Password.Type(pwd);
                Wait.WaitVisible(Next, 10);
                Next.Click();
            }
            catch (Exception e)
            {
                logger.Error("VerifyHomePage failed due to: " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Verify mail by sender

        public static void VerifyMailBySender()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(LoginGmailPageMail));
            try
            {
                Wait.WaitVisible(MailBySender,30);
                Wait.WaitVisible(MailBySender,10);
                MailBySender.Click();
            }
            catch (Exception e)
            {
                logger.Error("Verify Mail failed due to: " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        public static void ClickOnLink()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(LoginGmailPageMail));
            try
            {
                Wait.WaitVisible(Link, 10);
                Link.Click();
                Wait.WaitTime(20);
                Get.Windowhandle();
            }
            catch (Exception e)
            {
                logger.Error("Click On Link failed due to: " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

    }
}
