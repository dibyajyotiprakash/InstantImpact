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

namespace InstantImpact.Tests.InstantImpact.Sprint_03.Remove_From_Kart
{
    [TestClass]
    class _7248_RemoveAllItems : Base
    {
     
          public static ExtentTest test;
          [TestMethod]
          [TestCategory("IP_Sprint3")]
          public void RemoveAllItem()
            {
                try
                {
                    test = extent.CreateTest("_6280_Preview");
                    OpenBrowser(Browser.Chrome);
                    Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                    LoginPage.LoginToApplication("diageoadmin@centiv.com", "go2web");
                    HomePage.VerifyHomePage();
                    MyProjectsPage.VerifyProjectsPage();
                    MyProjectsPage.ClickOnShoppingCart();
                    ShoppingCartPage.VerifyShoppingCartPage();
                    //Remove all items
                }
                catch (Exception e)
                {
                    test.Fail("Remove Single Item failed" + e);
                }
            }
        }
}
