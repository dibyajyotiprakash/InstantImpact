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
    public class Atlas : Base
    {
        
        static Atlas()
        {
            Console.Out.WriteLine("Setting up project to Atlas");
            AtlasSiteData sd = new AtlasSiteData(Projects.Atlas);       
        }
    }
}
