using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using BrandmuscleAutomation.StartUp;
using InstantImpact.PageObject.UI.InstantImpact.Shopping_Cart;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.Tests.InstantImpact.Sprint_03.TemplateId_Reflect_on_Realted_Page
{
    [TestClass]
    class _7250_TemplateId_Should_Reflect : Base
    {
        public static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint3")]
        public void VerifyTemplateId()
        {
            try
            {
                test = extent.CreateTest("_7250_TemplateId_Should_Reflect");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnEdit();
                //string designname = MyProjectsPage
            }
            catch(Exception e)
            {
                test.Fail("Verify templateid failed" + e);
            }
        }
    }
}
