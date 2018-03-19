using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using BrandmuscleAutomation.Enum;
using BrandmuscleAutomation.Interactions;
using BrandmuscleAutomation.StartUp;
using InstantImpact.PageObject.UI.InstantImpact.Edit_Save;
using InstantImpact.PageObject.UI.InstantImpact.Delete_Preview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.Tests.InstantImpact.MyProjects
{
    [TestClass]
    public class _6209_MyProjects : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint1")]
        public void ViewMyProjects()
        {
            try
            {
                test = Base.extent.CreateTest("_6209_MyProjects");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("http://ii4.dev.brandmuscle.net/");
                Wait.WaitTime(5);
                LoginPage.LoginToApplication("diageoadmin@centiv.com", "go2web");
                HomePage.VerifyHomePage();
                MyProjectsPage.VerifyProjectsPage();
                Wait.WaitTime(5);
                MyProjectsPage.VerifyColorOfRow();
                Wait.WaitTime(10);
                MyProjectsPage.VerifyListOfTemplates();
                Wait.WaitTime(10);
                MyProjectsPage.FilterByDeisgnName();
                Wait.WaitTime(10);
                MyProjectsPage.VerifySortByDesignName();
            }
            catch(Exception e)
            {
                test.Fail("_6209_MyProjcets failed" + e);
            }
        }
    }
}
