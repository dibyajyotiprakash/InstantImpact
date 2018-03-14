using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrandmuscleAutomation.Enum;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace BrandmuscleAutomation.Data
{
    public class SiteData
    {
        public static string Username;
        public static string Password;
        public static string Url;

        public SiteData(Environments env)
        {
            #region setup vars for xml
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Path.GetFullPath("Assets") + "/SiteData.xml");
            var credentialBasePath = "/SiteData/Credentials/";
            var usernamepath = "";
            var passwordpath = "";
            var urlpath = "";
            #endregion

            #region switch case for env
            switch (env)
            {
                case Environments.Production:
                    usernamepath = "Production/username";
                    passwordpath = "Production/password";
                    urlpath = "Production/url";
                    break;
                case Environments.Demo:
                    usernamepath = "Demo/username";
                    passwordpath = "Demo/password";
                    urlpath = "Demo/url";
                    break;
                case Environments.QA:
                    usernamepath = "QA/username";
                    passwordpath = "QA/password";
                    urlpath = "QA/url";
                    break;
                case Environments.Dev:
                    usernamepath = "Dev/username";
                    passwordpath = "Dev/password";
                    urlpath = "Dev/url";
                    break;
                case Environments.ProductionQAAutomation:
                    usernamepath = "ProductionQAAutomation/username";
                    passwordpath = "ProductionQAAutomation/password";
                    urlpath = "ProductionQAAutomation/url";
                    break;
                case Environments.QAQAAutomation:
                    usernamepath = "ProductionQAAutomation/username";
                    passwordpath = "ProductionQAAutomation/password";
                    urlpath = "QAQAAutomation/url";
                    break;
                case Environments.StageQAAutomation:
                    usernamepath = "StageQAAutomation/username";
                    passwordpath = "StageQAAutomation/password";
                    urlpath = "StageQAAutomation/url";
                    break;
            }
            #endregion

            Username = xmlDoc.DocumentElement.SelectSingleNode(credentialBasePath + usernamepath).InnerText; 
            Password = xmlDoc.DocumentElement.SelectSingleNode(credentialBasePath + passwordpath).InnerText;
            Url = xmlDoc.DocumentElement.SelectSingleNode(credentialBasePath + urlpath).InnerText;
        }

        public SiteData(Projects project)
        {
            #region setup vars for xml
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Path.GetFullPath("Assets") + "/SiteData.xml");
            var EnvBasePath = "/SiteData/Environment/";
            string currentProject = "";
            string envBaseOnProject;
            #endregion

            #region switch case for getting env based on Project
            switch (project)
            {
                case Projects.V5:
                    currentProject = "V5Project";
                    break;
                case Projects.Atlas:
                    currentProject = "AtlasProject";
                    break;
                case Projects.MeowMeow:
                    currentProject = "MeowMeowProject";
                    break;
            }
            #endregion

            envBaseOnProject = xmlDoc.DocumentElement.SelectSingleNode(EnvBasePath + currentProject).InnerText.ToLower();

            switch (envBaseOnProject)
            {
                case "production":
                    new SiteData(Environments.Production);
                    break;
                case "qa":
                    new SiteData(Environments.QA);
                    break;
                case "stage":
                    new SiteData(Environments.Demo);
                    break;
                case "dev":
                    new SiteData(Environments.Dev);
                    break;
                case "productionqaautomation":
                    new SiteData(Environments.ProductionQAAutomation);
                    break;
                case "qaqaautomation":
                    new SiteData(Environments.QAQAAutomation);
                    break;
                case "stageqaautomation":
                    new SiteData(Environments.StageQAAutomation);
                    break;
                default:
                    Assert.Fail("Invalid Env Provided in SiteDataXML");
                    break;
            }

        }
    }
}
