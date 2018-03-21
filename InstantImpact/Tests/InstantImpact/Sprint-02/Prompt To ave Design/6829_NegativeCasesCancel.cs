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
    class _6829_NegativeCasesForCancel :Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint2")]
        public void VerifyPromptToSaveDesign()
        {
            try
            {
                test = Base.extent.CreateTest("_6829_NegativeCasesForCancel");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                Wait.WaitTime(5);
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                Wait.WaitTime(5);
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnEdit();
                CreateDesignPage.VerifyCreateDesignPage();
                CreateDesignPage.ClickOnPreviewChange();
                Wait.WaitTime(20);
                CreateDesignPage.ClickOnCancel();
                //Click on .......

            }
            catch (Exception e)
            {
                test.Fail("_6829_NegativeCasesForCancel" + e);
            }
        }
    }
}
