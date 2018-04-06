using System;
using AventStack.ExtentReports;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using BrandmuscleAutomation.StartUp;
using InstantImpact.PageObject.UI.InstantImpact.Help;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.Tests.InstantImpact.Sprint_03.Add_Multiple_Files_To_TariningGuides
{
    [TestClass]
    public class _7285_AddMultipleFiles : Base
    {
        public static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint3")]
        public void AddMutipleFiless()
        {
            try
            {
                test = extent.CreateTest("_7285_AddMultipleFiles");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                HomePage.ClickOnHelp();
                HelpPage.ClickOnTrainingGudes();
            }
            catch(Exception e)
            {
                test.Fail("Add Mutiple Files failed due to " + e);
            }
        }
    }
}
