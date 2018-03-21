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

namespace InstantImpact.Tests.InstantImpact.Sprint_02.Add_To_Kart
{
    [TestClass]
    class _6825_AddToCart :Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint2")]
        public static void AddToCart()
        {
            try
            {
                test = Base.extent.CreateTest("_6825_AddToCart");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                Wait.WaitTime(5);
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                Wait.WaitTime(5);
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                //Click on Add to Cart..
            }
            catch(Exception e)
            {
                test.Fail("_6825_AddToCart" + e);
            }
        }
    }
}
