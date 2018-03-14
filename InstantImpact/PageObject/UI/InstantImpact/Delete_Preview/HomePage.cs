﻿using System;
using log4net;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Interactions;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstantImpact.PageObject.UI.InstantImpact.Delete_Preview
{
    public class HomePage : Base
    {
        public static ExtentTest test;
        public static By DiageoLogo
        { get { return (By.Id("imgCorporationLogo")); } }
        public static By MyProject
        { get { return (By.XPath("//*[@href='/Account/MyProjectsPage.aspx']")); } }
        public static By YourAccount
        { get { return (By.XPath("//*[@href='/Account/MyAccountPage.aspx']")); } }

        public static By AccountsProjects
        { get { return (By.XPath("//*[@href='MyProjectsPage.aspx']")); } }

        public static void VerifyHomePage()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(HomePage));
            try
            {
                //Check the Title of Home page
                String actual_title= Driver.Title;
                Assert.IsTrue(actual_title.Contains("Home Page"), actual_title + "Error msg -Title does not contain Home Page");

                //Check the Diageo Logo
                Wait.WaitVisible(DiageoLogo,20);
                bool status_of_logo = DiageoLogo.IsElementDisplayed();
                Console.WriteLine("Status of logo is " + status_of_logo);

                //Check Your Account Button
                Wait.WaitVisible(YourAccount,20);
                bool status_of_myaacount = YourAccount.IsElementEnabled();
                Console.WriteLine("Status of your account button is " + status_of_myaacount);

                //Check My Project Button
                Wait.WaitVisible(MyProject,20);
                bool status_of_myproject = YourAccount.IsElementEnabled();
                Console.WriteLine("Status of my project button is " + status_of_myproject);

                //Click on My Project Button
                MyProject.Click();
            }
            catch (Exception e)
            {
                logger.Error("VerifyHomePage failed due to: " + e);
                //**Closing browser
                Driver.Quit();
                throw e;      
            }

        }

        //Click on Accounts
        public static void AccountsToProjects()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("AccountsToProjects");
            try
            {
                YourAccount.Click();
                AccountsProjects.Click();
            }
            catch (Exception e)
            {
                logger.Error("Navigate from acconts to projects failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

    }
}