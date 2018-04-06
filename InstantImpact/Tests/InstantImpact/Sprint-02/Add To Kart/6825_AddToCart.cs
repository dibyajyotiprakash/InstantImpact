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
    public class _6825_AddToCart : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint2")]
        public void AddToCart()
        {
            try
            {
                test = extent.CreateTest("_6825_AddToCart");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnAddtoKart();
                SelectProductDetailsPage.VerifySelectProductDetailsPage();
                SelectProductDetailsPage.CancelSelectProductDetails();
                MyProjectsPage.VerifyProjectsPage();
            }
            catch(Exception e)
            {
                test.Fail("_6825_AddToCart" + e);
            }
        }
    }
}
