using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.Tests.InstantImpact.Delete
{
    [TestClass]
    public class _6701_DeleteNegativeCases : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint1")]
        public void NegativeCases()
        {
            try
            {
                test = Base.extent.CreateTest("_6701_DeleteNegativeCases");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com", "go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.ClickDeleteSelectWithoutCheck();
                MyProjectsPage.DismissPopupSingleTemplate();
                MyProjectsPage.DismissPopupMultipleTemplate();
                MyProjectsPage.DismissPopupAllTemplate();
                test.Pass("_6701_NegativeCases passed");
                Driver.Quit();
            }
            catch (Exception e)
            {
                test.Fail("_6701_DeleteNegativeCases failed" + e);
            }

        }
    }
}
