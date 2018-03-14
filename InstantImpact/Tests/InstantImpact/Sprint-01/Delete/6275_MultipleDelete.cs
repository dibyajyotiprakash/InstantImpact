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
    public class _6275_MultipleDelete : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint1")]
        public void MultipleDelete()
        {
            try
            {
                test = Base.extent.CreateTest("_6275_MultipleDelete");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                Wait.WaitTime(5);
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                Wait.WaitTime(5);
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyHomePage();
                MyProjectsPage.DeleteMultipleTemplates();
                test.Pass("_6275_MultipleDelete" + "passed");
                Driver.Quit();
            }
            catch (Exception e)
            {
                test.Fail("_6275_MultipleDelete" + e);
                Driver.Quit();
            }
        }
    }
}
