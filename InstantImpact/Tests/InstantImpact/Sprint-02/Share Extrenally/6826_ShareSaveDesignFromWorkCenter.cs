using System;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using InstantImpact.PageObject.UI.InstantImpact.Gmail;
using InstantImpact.PageObject.UI.InstantImpact.Share;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.Tests.InstantImpact.Sprint_02.Share_Extrenally
{
    [TestClass]
    public class _6826_ShareSaveDesignFromWorkCenter : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint2")]
        public void ShareTemplateExternally()
        {
            try
            {
                test = extent.CreateTest("_6826_ShareSaveDesignFromWorkCenter");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com", "go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnShare();
                ShareTemplatePage.ShareTemplate("qa.brandmuscle@gmail.com");
                Navigation.GoToURL("https://www.gmail.com");
                Wait.WaitForPageToLoad();
                LoginGmailPageMail.LoginToGmail("qa.brandmuscle@gmail.com", "brandmuscle");
                LoginGmailPageMail.VerifyMailBySender();
                LoginGmailPageMail.ClickOnLink();
                Driver.Quit();
            }
            catch (Exception e)
            {
                test.Fail("_6826_ShareSaveDesignFromWorkCenter" + e);
            }
        }
    }
}
