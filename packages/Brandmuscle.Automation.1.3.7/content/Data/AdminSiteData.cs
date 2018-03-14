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
    public class AdminSiteData
    {
        public static string adminUser;
        public static string adminPassword;
        public static string adminUrl;

        public AdminSiteData(Environments env)
        {
            #region setup vars for xml
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Path.GetFullPath("Assets") + "/AdminSiteData.xml");
            var credentialBasePath = "/AdminSiteData/Credentials/";
            var usernamepath = "";
            var passwordpath = "";
            var urlpath = "";
            #endregion

            #region switch case for env
            switch (env)
            {
                //case Environments.Production:
                //    usernamepath = "Production/username";
                //    passwordpath = "Production/password";
                //    urlpath = "Production/url";
                //    break;
                //case Environments.Demo:
                //    usernamepath = "Demo/username";
                //    passwordpath = "Demo/password";
                //    urlpath = "Demo/url";
                //    break;
                //case Environments.QA:
                //    usernamepath = "QA/username";
                //    passwordpath = "QA/password";
                //    urlpath = "QA/url";
                //    break;
                //case Environments.Dev:
                //    usernamepath = "Dev/username";
                //    passwordpath = "Dev/password";
                //    urlpath = "Dev/url";
                //    break;
                case Environments.ProductionQAAutomation:
                    usernamepath = "ProductionQAAutomation/adminUser";
                    passwordpath = "ProductionQAAutomation/adminPassword";
                    urlpath = "ProductionQAAutomation/adminUrl";
                    break;
                case Environments.QAQAAutomation:
                    usernamepath = "ProductionQAAutomation/adminUser";
                    passwordpath = "ProductionQAAutomation/adminPassword";
                    urlpath = "QAQAAutomation/adminUrl";
                    break;
                case Environments.StageQAAutomation:
                    usernamepath = "StageQAAutomation/adminUser";
                    passwordpath = "StageQAAutomation/adminPassword";
                    urlpath = "StageQAAutomation/adminUrl";
                    break;
            }
            #endregion

            adminUser = xmlDoc.DocumentElement.SelectSingleNode(credentialBasePath + usernamepath).InnerText; 
            adminPassword = xmlDoc.DocumentElement.SelectSingleNode(credentialBasePath + passwordpath).InnerText;
            adminUrl = xmlDoc.DocumentElement.SelectSingleNode(credentialBasePath + urlpath).InnerText;
        }

        public AdminSiteData(Projects project)
        {
            #region setup vars for xml
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Path.GetFullPath("Assets") + "/AdminSiteData.xml");
            var EnvBasePath = "/AdminSiteData/Environment/";
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
                //case "production":
                //    new AdminSiteData(Environments.Production);
                //    break;
                //case "qa":
                //    new AdminSiteData(Environments.QA);
                //    break;
                //case "stage":
                //    new AdminSiteData(Environments.Demo);
                //    break;
                //case "dev":
                //    new AdminSiteData(Environments.Dev);
                //    break;
                case "productionqaautomation":
                    new AdminSiteData(Environments.ProductionQAAutomation);
                    break;
                case "qaqaautomation":
                    new AdminSiteData(Environments.QAQAAutomation);
                    break;
                case "stageqaautomation":
                    new AdminSiteData(Environments.StageQAAutomation);
                    break;

                default:
                    Assert.Fail("Invalid Env Provided in SiteDataXML");
                    break;
            }

        }
    }
}
