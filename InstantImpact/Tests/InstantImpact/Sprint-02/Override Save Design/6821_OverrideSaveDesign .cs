using System;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using InstantImpact.PageObject.UI.InstantImpact.Edit_Save;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.Tests.InstantImpact.Sprint_02
{
    [TestClass]
    public class _6821_OverrideSaveDesign : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint2")]
        public void OverWriteDesignNameFromEdit()
        {
            try
            {
                test = extent.CreateTest("_6821_OverrideSaveDesign");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnEdit();
                CreateDesignPage.VerifyCreateDesignPage();
                CreateDesignPage.VerifyPreviewChanges();
                //CreateDesignPage.ClickOnYesInOverWritePopup();
                CreateDesignPage.OverWriteExistingNameWithYes();
                CreateDesignPage.VerifyConfirmationMsg();
                Driver.Quit();
            }
            catch (Exception e)
            {
                test.Fail("_6821_OverrideSaveDesign" + e);
                Assert.Fail();
            }
        }
    }
}
