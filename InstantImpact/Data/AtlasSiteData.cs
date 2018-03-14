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
    public class AtlasSiteData
    {
        public static string adminUser;
        public static string adminPassword;
        public static string adminUrl;

        public AtlasSiteData(Environments env)
        {
            #region setup vars for xml
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Path.GetFullPath("Assets") + "/AtlasSiteData.xml");
            var credentialBasePath = "/AtlasSiteData/Credentials/";
            var usernamepath = "";
            var passwordpath = "";
            var urlpath = "";
            #endregion

            #region switch case for env
            switch (env)
            {
                case Environments.ProductionDirecTV:
                    usernamepath = "ProductionDirecTV/adminUser";
                    passwordpath = "ProductionDirecTV/adminPassword";
                    urlpath = "ProductionDirecTV/adminUrl";
                    break;
                case Environments.QADirecTV:
                    usernamepath = "QADirecTV/adminUser";
                    passwordpath = "QADirecTV/adminPassword";
                    urlpath = "QADirecTV/adminUrl";
                    break;
                case Environments.StageDirecTV:
                    usernamepath = "StageDirecTV/adminUser";
                    passwordpath = "StageDirecTV/adminPassword";
                    urlpath = "StageDirecTV/adminUrl";
                    break;
            }
            #endregion

            adminUser = xmlDoc.DocumentElement.SelectSingleNode(credentialBasePath + usernamepath).InnerText; 
            adminPassword = xmlDoc.DocumentElement.SelectSingleNode(credentialBasePath + passwordpath).InnerText;
            adminUrl = xmlDoc.DocumentElement.SelectSingleNode(credentialBasePath + urlpath).InnerText;
        }

        public AtlasSiteData(Projects project)
        {
            #region setup vars for xml
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Path.GetFullPath("Assets") + "/AtlasSiteData.xml");
            var EnvBasePath = "/AtlasSiteData/Environment/";
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
                case "productiondirectv":
                    new AtlasSiteData(Environments.ProductionDirecTV);
                    break;
                case "qadirectv":
                    new AtlasSiteData(Environments.QADirecTV);
                    break;
                case "stagedirectv":
                    new AtlasSiteData(Environments.StageDirecTV);
                    break;
                default:
                    Assert.Fail("Invalid Env Provided in AtlasSiteDataXML");
                    break;
            }

        }
    }
}
