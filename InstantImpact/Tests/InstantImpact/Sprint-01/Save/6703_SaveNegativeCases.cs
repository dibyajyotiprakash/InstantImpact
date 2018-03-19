using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using BrandmuscleAutomation.StartUp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InstantImpact.PageObject.UI.InstantImpact.Edit_Save;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;

namespace InstantImpact.Tests.InstantImpact.Save
{
    [TestClass]
    public class _6703_SaveNegativeCases : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint1")]
        public void CancelSaveDesign()
        {
            try
            {
                test = Base.extent.CreateTest("_6703_SaveNegativeCases");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                Wait.WaitTime(5);
                LoginPage.LoginToApplication("diageoadmin@centiv.com","go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                MyProjectsPage.ClickOnEdit();
                CreateDesignPage.VerifyCreateDesignPage();
                CreateDesignPage.VerifyPreviewChanges();
                CreateDesignPage.ClickOnPreviewChange();
                Wait.WaitTime(40);
                CreateDesignPage.CancelSaveDesignName("template");
                Wait.WaitTime(20);
                CreateDesignPage.VerifyExistingDesignAlertMsg();                
                test.Pass("_6703_SaveNegativeCases passed");
            }
            catch(Exception e)
            {
                test.Fail("_6703_SaveNegativeCases failed" + e);
            }
        }
    }
}
