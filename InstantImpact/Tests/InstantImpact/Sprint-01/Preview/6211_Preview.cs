using System;
using AventStack.ExtentReports;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using BrandmuscleAutomation.StartUp;
using InstantImpact.PageObject.UI.InstantImpact.Edit_Save;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.Tests.InstantImpact.Preview
{
    [TestClass]
    public class _6211_Preview : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint1")]
        public void PreviewTemplate()
        {
            try
            {
                test = extent.CreateTest("_6211_Preview");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com", "go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnPreview();
                Driver.Quit();
            }
            catch(Exception e)
            {
                test.Fail("_6211_Preview failed" + e);
            }
        }
    }
}
