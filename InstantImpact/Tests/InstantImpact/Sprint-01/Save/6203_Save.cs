using AventStack.ExtentReports;
using BrandmuscleAutomation.StartUp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InstantImpact.PageObject.UI.InstantImpact.Edit_Save;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;

namespace InstantImpact.Tests.InstantImpact.Save
{
    [TestClass]
    public class _6203_Save : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint1")]
        public void SaveDesign()
        {
            try
            {
                test = Base.extent.CreateTest("_6203_Save");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                Wait.WaitTime(5);
                LoginPage.LoginToApplication("diageoadmin@centiv.com", "go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyHomePage();
                MyProjectsPage.ClickOnEdit();
                CreateDesignPage.VerifyCreateDesignPage();
                CreateDesignPage.VerifyPreviewChanges();
                CreateDesignPage.ClickOnPreviewChange();
                Wait.WaitTime(50);
                CreateDesignPage.VerifySaveDesign("template1");
                test.Pass("_6203_Save passed");
                Driver.Quit();
            }
            catch (Exception e)
            {
                test.Fail("_6203_Save failed" + e);
            }
        }
    }
}
