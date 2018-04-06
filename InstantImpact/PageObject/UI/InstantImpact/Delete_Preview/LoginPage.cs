using System;
using OpenQA.Selenium;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Interactions;
using log4net;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework; 

namespace InstantImpact.PageObject.UI.InstantImpact.Delete_Preview
{
    public class LoginPage : Base
    {    
    public static By InstantImpactLogo
    { get { return (By.XPath("//*[contains(text(),'Instant Impact Login')]")); } }

    public static By Email
    { get { return (By.Id("UserName")); } }

    public static By Password
    { get { return (By.Id("Password")); } }

    public static By LoginButton
    { get { return (By.Id("btnLogin")); } }

    public  static void LoginToApplication(string email,string pwd)
    {       
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(LoginPage));
            try
            {
                //Verify Title of Login page
                string actual_title = Driver.Title;
                Assert.IsTrue(actual_title.Contains("Instant Impact"), actual_title + "Error msg -Title does not contain Log in");

                //Verify Logo visibilty
                Wait.WaitVisible(InstantImpactLogo, 60);
                InstantImpactLogo.IsElementDisplayed();

                //Login
                Email.Type(email);
                Password.Type(pwd);
                LoginButton.Click();
            }
            catch (Exception e)
            {
                logger.Error("LoginToApplication failed due to: " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }

        }

    }
}