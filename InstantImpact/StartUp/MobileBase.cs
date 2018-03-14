using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using BrandmuscleAutomation.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;

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
    public class MobileBase
    {
        public static IWebDriver Driver;
        public static string CurrentWindow;
         
        static MobileBase()
        {
            Console.Out.WriteLine("Starting Mobile Automation");
        }
   
        internal static void OpenBrowser(Browser browser)
        {
            switch (browser) 
            {
                case Browser.Chrome:
                    DesiredCapabilities capabilities = new DesiredCapabilities();
                    //capabilities.SetCapability("device", "Android");
                    capabilities.SetCapability("browserName", "chrome");
                    capabilities.SetCapability("deviceName", "SAMSUNG-SM-G920A");
                    capabilities.SetCapability("platformName", "Android");
                    //capabilities.SetCapability("platformVersion", "23");
                    Driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(180));
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
