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

namespace InstantImpact.Tests.InstantImpact.Sprint_02.Override_Save_Design
{
    [TestClass]
    public class _6822_SaveNewDesignName : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint2")]
        public void SaveNewDeisgnFromEdit()
        {
            try
            {
                test = extent.CreateTest("_6822_SaveNewDesignName");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                LoginPage.LoginToApplication("diageoadmin@centiv.com", "go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnEdit();
                CreateDesignPage.VerifyCreateDesignPage();
                CreateDesignPage.VerifyPreviewChanges();
                CreateDesignPage.ClickOnSave();
                CreateDesignPage.ClickOnSaveInSaveDesignPopup();
                CreateDesignPage.ClickOnNoInOverWritePopup();
                CreateDesignPage.ClearTextInSaveDesignPopup();
                CreateDesignPage.SaveDesignWithNewName("template");
                Driver.Quit();

            }
            catch (Exception e)
            {
                test.Fail("_6822_SaveNewDesignName" + e);
                Assert.Fail();
            }
        }
    }
}
