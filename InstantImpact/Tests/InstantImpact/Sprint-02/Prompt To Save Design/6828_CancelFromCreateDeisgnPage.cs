using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class _6828_CancelFromCreateDeisgnPage : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint2")]
        public void ClickOnCancelNextStep()
        {
            try
            {
                test = extent.CreateTest("_6828_CancelFromCreateDeisgnPage");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnEdit();
                CreateDesignPage.VerifyCreateDesignPage();
                CreateDesignPage.VerifyPreviewChanges();
                CreateDesignPage.ClickOnCancel();
                CreateDesignPage.ClickOnYesFromCancel();
                CreateDesignPage.VerifyExistenceOfSaveDesignPopup();
                Driver.Quit();
            }
            catch (Exception e)
            {
                test.Fail("_6828_CancelFromCreateDeisgnPage" + e);
            }
        }
    }
}
