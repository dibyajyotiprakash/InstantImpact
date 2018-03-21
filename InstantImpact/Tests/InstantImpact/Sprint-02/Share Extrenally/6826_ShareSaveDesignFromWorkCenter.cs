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
using InstantImpact.PageObject.UI.InstantImpact.Gmail;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.Tests.InstantImpact.Sprint_02.Share_Extrenally
{
    [TestClass]
    public class _6826_ShareSaveDesignFromWorkCenter : Base
    {
        private static ExtentTest test;
        [TestMethod]
        [TestCategory("IP_Sprint2")]
        public void LoginGmail()
        {
            try
            {
                test = Base.extent.CreateTest("_6826_ShareSaveDesignFromWorkCenter");
                OpenBrowser(Browser.Chrome);
                Navigation.GoToURL("https://www.gmail.com");
                Wait.WaitTime(5);
                LoginGmailPageMail.LoginToGmail("qa.brandmuscle@gmail.com", "brandmuscle");
                LoginGmailPageMail.VerifyMailBySender();
                LoginGmailPageMail.ClickOnLink();
            }
            catch (Exception e)
            {
                test.Fail("_6826_ShareSaveDesignFromWorkCenter" + e);
            }
        }
    }
}
