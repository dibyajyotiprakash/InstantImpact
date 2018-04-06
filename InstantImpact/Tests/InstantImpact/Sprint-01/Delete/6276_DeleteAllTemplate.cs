using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;

namespace InstantImpact.Tests.InstantImpact
{
    [TestClass]
    public class _6276_DeleteAllTemplate : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint1")]
        public void DeleteAll()
        {
            try
            {
                test = extent.CreateTest("_6276_DeleteAllTemplate");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com", "go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.DeleteAllTemplates();
                test.Pass("_6276_MultipleDelete passed");
                Driver.Quit();
            }
            catch (Exception e)
            {
                test.Fail("_6276_Delete failed" + e);
                Driver.Quit();
            }
        }
    }
}
