using Microsoft.VisualStudio.TestTools.UnitTesting;
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

namespace InstantImpact.Tests.InstantImpact
{
    [TestClass]
   public class _6198_Delete : Base
    {
        private static ExtentTest test;
         [TestMethod]
         [TestCategory("IP_Sprint1")]
         public void SingleDelete()
        {
            //
            try
            {
            test = Base.extent.CreateTest("_6198_Delete");
            OpenBrowser(Browser.Chrome);
            Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
            Wait.WaitTime(5);
            LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
            Wait.WaitTime(5);
            HomePage.VerifyHomePage();
            MyProjectsPage.DeleteSingleTemplate();
            test.Pass(" _6198_Delete passed");
            Driver.Quit();
            }
            catch(Exception e)
            {
                test.Fail(" _6198_Delete failed"+e);
            }

        }
    }
}
