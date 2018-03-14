
using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using OpenQA.Selenium.Firefox;
using BrandmuscleAutomation.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BrandmuscleAutomation.StartUp
{
    [TestClass]
    [DeploymentItem(@"Assets\chromedriver.exe", @"Assets")]
    [DeploymentItem(@"Assets\IEDriverServer.exe", @"Assets")]
    [DeploymentItem(@"Assets\MicrosoftWebDriver.exe", @"Assets")]
    [DeploymentItem(@"Assets\geckodriver.exe", @"Assets")]
    [DeploymentItem(@"Data\SiteData.xml", @"Assets")]
    [DeploymentItem(@"Data\AdminSiteData.xml", @"Assets")]
    [DeploymentItem(@"Data\AtlasSiteData.xml", @"Assets")]
    [DeploymentItem(@"ExcelFile\ClientsURLs.xlsx", @"Assets")]
    public class Base
    {
        public static IWebDriver Driver;
        public static string CurrentWindow;
        //private static IWebDriver driver;
        public static ExtentReports extent;
        private static ExtentHtmlReporter htmlReporter;

        //TODO: SonarQube should get a smelly code
        [TestInitialize]
        public void SetupReporting()
        {
            htmlReporter = new ExtentHtmlReporter(@"D:\Software"+DateTime.Now.ToString("dd_MMM_yy_HH_mm_ss_tt") + ".html");

            htmlReporter.Configuration().Theme = Theme.Dark;

            htmlReporter.Configuration().DocumentTitle = "AutomationStatus";

            htmlReporter.Configuration().ReportName = "AutomationStatus";

            /*htmlReporter.Configuration().JS = "$('.brand-logo').text('test image').prepend('<img src=@"file:///D:\Users\jloyzaga\Documents\FrameworkForJoe\FrameworkForJoe\Capgemini_logo_high_res-smaller-2.jpg"> ')";*/
           // htmlReporter.Configuration().JS = "$('.brand-logo').text('').append('<img src=D:\\Users\\jloyzaga\\Documents\\FrameworkForJoe\\FrameworkForJoe\\Capgemini_logo_high_res-smaller-2.jpg>')";
            extent = new ExtentReports();

            extent.AttachReporter(htmlReporter);
        }

        public static void ItriggerSonarQubeForZeroExceptionError()
        {
            try
            {
                int num1 = 0;
                int num2 = 3;
                int wrong = num2 / num1;
            }
            catch
            {


            }
        }

        static Base()
        {
            Console.Out.WriteLine("Starting Automation");
            ////D:\Software\OwnReport_
            //htmlReporter = new ExtentHtmlReporter(@"D:\Software\OwnReport_" + DateTime.Now.ToString("dd_MMM_yy_HH_mm_ss_tt") + ".html");
            ////F:\JenkinsSlave\atlas_LoadTest\workspace\Automation\LB Automation\LB-PerformanceTest\lb-result.csv
            //htmlReporter.Configuration().Theme = Theme.Dark;

            //htmlReporter.Configuration().DocumentTitle = "AutomationStatus";

            //htmlReporter.Configuration().ReportName = "AutomationStatus";

            ///*htmlReporter.Configuration().JS = "$('.brand-logo').text('test image').prepend('<img src=@"file:///D:\Users\jloyzaga\Documents\FrameworkForJoe\FrameworkForJoe\Capgemini_logo_high_res-smaller-2.jpg"> ')";*/
            //htmlReporter.Configuration().JS = "$('.brand-logo').text('').append('<img src=D:\\Users\\jloyzaga\\Documents\\FrameworkForJoe\\FrameworkForJoe\\Capgemini_logo_high_res-smaller-2.jpg>')";
            //extent = new ExtentReports();

//            extent.AttachReporter(htmlReporter);
        }

        internal static void OpenBrowser(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    Driver = new ChromeDriver(Path.GetFullPath("Assets"));
                    break;
                case Browser.Firefox:
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(Path.GetFullPath("Assets"));
                    Driver = new FirefoxDriver(service);
                    break;
                case Browser.InternetExplorer:
                    Driver = new InternetExplorerDriver(Path.GetFullPath("Assets"));
                    break;
                case Browser.Edge:
                    Driver = new EdgeDriver(Path.GetFullPath("Assets"));
                    break;
            }
            Driver.Manage().Window.Maximize();
            CurrentWindow = Driver.CurrentWindowHandle;
        }

        internal static void OpenBrowserSpecificDownload(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    ChromeOptions options = new ChromeOptions();
                    options.AddUserProfilePreference("download.default_directory", "C:\\SeleniumRunTest\\");
                    Driver = new ChromeDriver(Path.GetFullPath("Assets"), options);
                    break;
                case Browser.Firefox:
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(Path.GetFullPath("Assets"));
                    Driver = new FirefoxDriver(service);
                    break;
                case Browser.InternetExplorer:
                    Driver = new InternetExplorerDriver(Path.GetFullPath("Assets"));
                    break;
                case Browser.Edge:
                    Driver = new EdgeDriver(Path.GetFullPath("Assets"));
                    break;
            }
            Driver.Manage().Window.Maximize();
            CurrentWindow = Driver.CurrentWindowHandle;
        }

        internal static void CloseBrowser()
        {
            Driver.Quit();
        }

        [TestCleanup]
        public void GenerateReport()
        {
         extent.Flush();
        }

        [TestCleanup]
        public void TearDownTest()
        {
            try
            {
                Driver.Quit();
            }
            catch
            {

            }
        }
    }
}
