using System;
using BrandmuscleAutomation.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Xml;
using System.IO;

namespace BrandmuscleAutomation.Data
{
    static class BackendData
    {
        public static string ClientManagementConnection { get; set; }
        public static string DataFeedConnection { get; set; }
        public static string StagingTables { get; set; }
        public static string StoreProcedures { get; set; }
        public static string ClientName { get; set; }
        public static void SetupEnv(Environments env)
        {
            switch (env)
            {
                case Environments.Production:
                    ClientManagementConnection = ConfigurationManager.ConnectionStrings["ClientManagement"].ConnectionString;
                    DataFeedConnection = ConfigurationManager.ConnectionStrings["ClientManagement"].ConnectionString;
                    break;
                case Environments.UAT:
                    ClientManagementConnection = ConfigurationManager.ConnectionStrings["ClientManagementU"].ConnectionString;
                    DataFeedConnection = ConfigurationManager.ConnectionStrings["DatafeedU"].ConnectionString;
                    break;
                case Environments.Demo:
                    ClientManagementConnection = ConfigurationManager.ConnectionStrings["ClientManagementDemo"].ConnectionString;
                    DataFeedConnection = ConfigurationManager.ConnectionStrings["ClientManagementDemo"].ConnectionString;
                    break;
                case Environments.Stage:
                    ClientManagementConnection = ConfigurationManager.ConnectionStrings["ClientManagementS"].ConnectionString;
                    DataFeedConnection = ConfigurationManager.ConnectionStrings["ClientManagementS"].ConnectionString;
                    break;
                case Environments.Dev:
                    ClientManagementConnection = ConfigurationManager.ConnectionStrings["ClientManagementD"].ConnectionString;
                    DataFeedConnection = ConfigurationManager.ConnectionStrings["DataFeedD"].ConnectionString;
                    break;
                case Environments.QA:
                    ClientManagementConnection = ConfigurationManager.ConnectionStrings["ClientManagementq"].ConnectionString;
                    DataFeedConnection = ConfigurationManager.ConnectionStrings["ClientManagementq"].ConnectionString;
                    break;
                default:
                    Assert.Fail("Invalid Environment Provided: " + env);
                    break;
            }
        }
        public static void GetTablesProc(BackendClients client)
        {
            #region setup vars for xml
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Path.GetFullPath("Assets") + "/UserFeeds.xml");
            var stagingtablesbase = "/BackendData/UserFeed/StagingTables/";
            var storeproceduresbase = "/BackendData/UserFeed/StoredProcedures/";
            var clientbase = "";
            #endregion
            switch (client)
            {
                case BackendClients.PMA:
                    clientbase = "PMA";
                    break;
                case BackendClients.DirectTV:
                    clientbase = "DirectTV";
                    break;
                case BackendClients.Progressive:
                    clientbase = "Progressive";
                    break;
                default:
                    Assert.Fail("Invalid client Provided: " + client);
                    break;
            }
            ClientName = clientbase.ToLower();
            StagingTables = xmlDoc.DocumentElement.SelectSingleNode(stagingtablesbase + clientbase).InnerText;
            StoreProcedures = xmlDoc.DocumentElement.SelectSingleNode(storeproceduresbase + clientbase).InnerText;
        }
        public static string GenerateUserName(string ClientName)
        {
            string userName = "auto" + ClientName.ToLower() + DateTime.Now.ToString();
            userName = userName.Replace("-", "");
            userName = userName.Replace(" ", "");
            userName = userName.Replace(":", "");
            userName = userName.ToLower();
            Console.WriteLine("Generated user name ->" + userName);
            return userName;
        }
    }
}
