using System;
using BrandmuscleAutomation.StartUp;
using log4net;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using BrandmuscleAutomation.Interactions;

namespace InstantImpact.PageObject.UI.InstantImpact.Share
{
    class ShareTemplatePage : Base
    {
        public static ExtentTest test;
        public static By SenderMail
        { get { return (By.XPath("//*[@id='txtEmail']")); } }

        public static By Add
        { get { return (By.XPath("//*[@id='Body_AddEmails']")); } }

        public static By Subject
        { get { return (By.XPath("//*[@id='Body_Txt_Subject']")); } }

        public static By Send
        { get { return (By.XPath("//*[@id='Body_btnShare']")); } }

        public static By ConfirmationMsgPopup
        { get { return (By.XPath("//*[@id='ctl00_Body_ucMB_ucRadNotification_C_radNotifyTextWrapper']")); } }

        //Share Template
        public static void ShareTemplate(string sendermailid)
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(ShareTemplatePage));
            try
            {
                Wait.WaitForPageToLoad();
                Wait.WaitVisible(SenderMail,30);
                SenderMail.Type(sendermailid);
                Wait.WaitVisible(Send,10);
                Clicks.ScrollToViewElement(Send);
                Send.Click();
                string msg = ConfirmationMsgPopup.GetText();
                Console.WriteLine("Message is " + msg);
            }
            catch (Exception e)
            {
                logger.Error("Share Template is failed due to: " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }
    }
}
