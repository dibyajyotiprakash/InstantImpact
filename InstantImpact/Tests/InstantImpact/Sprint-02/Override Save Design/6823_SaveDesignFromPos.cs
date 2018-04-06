using System;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using InstantImpact.PageObject.UI.InstantImpact.Edit_Save;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InstantImpact.PageObject.UI.InstantImpact.OverwriteSavePrompt;

namespace InstantImpact.Tests.InstantImpact.Sprint_02
{
    [TestClass]
    public class _6823_SaveDesignFromPos : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint2")]
        public void SaveExistingDesignNameFromPos()
        {
            try
            {
                test = extent.CreateTest("_6823_SaveDesignFromPos");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                string designname= MyProjectsPage.GetExistingName();
                MyProjectsPage.ClickOnPosOnDemand();
                POS_On_Demand.SelectTemplate();
                CreateDesignPage.VerifyPreviewChanges();
                CreateDesignPage.ClickOnSave();
                CreateDesignPage.GiveExistingName(designname);
                CreateDesignPage.ClickOnSaveInSaveDesignPopup();
                CreateDesignPage.ClickOnYesInOverWritePopup();
                CreateDesignPage.VerifyConfirmationMsg();
                Driver.Quit();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                test.Fail("_6823_SaveDesignFromPos" + e);
                Assert.Fail();
            }
        }
    }
}
