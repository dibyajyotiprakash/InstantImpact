﻿using System;
using AventStack.ExtentReports;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using BrandmuscleAutomation.StartUp;
using InstantImpact.PageObject.UI.InstantImpact.Edit_Save;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.Tests.InstantImpact.Edit
{
    [TestClass]
    public class _6702_EditNegative : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint1")]
        public void CancelCreateDesign()
        {
            try
            {
                test = extent.CreateTest("_6702_EditNegative");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnEdit();
                CreateDesignPage.VerifyCreateDesignPage();
                CreateDesignPage.ClickOnCancel();
                CreateDesignPage.ClickOnNoFromCancel();
                Driver.Quit();
            }
            catch (Exception e)
            {
                test.Fail("_6702_Edit_Negative failed" + e);
            }
        }
    }
}
