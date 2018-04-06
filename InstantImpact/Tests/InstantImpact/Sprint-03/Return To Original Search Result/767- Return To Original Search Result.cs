using System;
using AventStack.ExtentReports;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using BrandmuscleAutomation.StartUp;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using InstantImpact.PageObject.UI.InstantImpact.OverwriteSavePrompt;
using InstantImpact.PageObject.UI.InstantImpact.Edit_Save;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.Tests.InstantImpact.Sprint_03.Return_To_Original_Search_Result
{
    [TestClass]
    public class _767__Return_To_Original_Search_Result : Base
    {
        public static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint3")]
        public void ReturnToOriginalSearchPage()
        {
            try
            {
                test = extent.CreateTest("_767__Return_To_Original_Search_Result");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                HomePage.VerifyHomePage();
                HomePage.ClickOnProjects();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnPosOnDemand();
                POS_On_Demand.SelectTemplate();
                CreateDesignPage.VerifyPreviewChanges();
                CreateDesignPage.ClickOnNextStep();
                CreateDesignPage.ClickOnNoFromNextStep();
                SelectProductDetailsPage.VerifySelectProductDetailsPage();
                SelectProductDetailsPage.ClickOnBack();
                SelectProductDetailsPage.ClickYesFromBack();
                POS_On_Demand.VerifyPosOnDemand();
            }
            catch(Exception e)
            {
                test.Fail("Return To Original Search Page failed due to " + e);
            }
        }
    }
}
