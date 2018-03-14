using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using BrandmuscleAutomation.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrandmuscleAutomation.Data;

namespace BrandmuscleAutomation.StartUp
{
    [TestClass]
    public class V5Base : Base
    {
        static V5Base()
        {
            Console.Out.WriteLine("Setting up project to V5");
            SiteData sd = new SiteData(Projects.V5);
            AdminSiteData asd = new AdminSiteData(Projects.V5);
        }
    }
}
