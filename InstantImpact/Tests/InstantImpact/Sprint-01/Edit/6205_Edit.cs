using AventStack.ExtentReports;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using BrandmuscleAutomation.StartUp;
using InstantImpact.PageObject.UI.InstantImpact.Edit_Save;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InstantImpact.Tests.InstantImpact.Edit
{
    [TestClass]
    public class _6205_Edit :Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint1")]
        public void EditTemplate()
        {
            try
            {
                test = extent.CreateTest("_6205_Edit");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com", "go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnEdit();
                CreateDesignPage.VerifyCreateDesignPage();
                CreateDesignPage.VerifyPreviewChanges();
                CreateDesignPage.VerifyViewProof();
                test.Pass("_6205_Edit" + "passed");
                Driver.Quit();
            }
            catch(Exception e)
            {
                test.Fail("_6205_Edit failed" + e);
            }
        }
    }
}
