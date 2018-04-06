using System;
using AventStack.ExtentReports;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using BrandmuscleAutomation.StartUp;
using InstantImpact.PageObject.UI.InstantImpact.Shopping_Cart;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.Tests.InstantImpact.Sprint_03.Remove_From_Kart
{
    [TestClass]
    public class _7247_RemoveOneItem : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint3")]
        public void RemoveSingleItem()
        {
            try
            {
                test = extent.CreateTest("_7247_RemoveOneItem");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnShoppingCart();
                ShoppingCartPage.VerifyShoppingCartPage();
                //Remove one item
            }
            catch (Exception e)
            {
                test.Fail("Remove Single Item failed due to " + e);
            }
        }
    }
}
