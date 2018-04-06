using System;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using InstantImpact.PageObject.UI.InstantImpact.Edit_Save;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.Tests.InstantImpact.Sprint_02.Prompt_To_ave_Design
{
    [TestClass]
    public class _6824_Prompt_SaveDesign : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint2")]
        public void VerifyPromptToSaveDesign()
        {
            try
            {
                test = extent.CreateTest("_6824_Prompt_SaveDesign");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnEdit();
                CreateDesignPage.VerifyCreateDesignPage();
                CreateDesignPage.VerifyPreviewChanges();
                CreateDesignPage.ClickOnNextStep();
                CreateDesignPage.ClickOnYes();
                CreateDesignPage.ClearTextInSaveDesignPopup();
                CreateDesignPage.SaveDesignWithNewName("template1");
                SelectProductDetailsPage.VerifySelectProductDetailsPage();
                Driver.Quit();
            }
            catch (Exception e)
            {
                test.Fail("_6824_Prompt_SaveDesign" + e);
            }
        }
    }
}
