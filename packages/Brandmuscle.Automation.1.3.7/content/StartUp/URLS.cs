using BrandmuscleAutomation.Enum;
using System;

namespace BrandmuscleAutomation.StartUp
{
    class URLS
    {
        public static string Production { get { return "http://admintool.brandmuscle.net/"; } }
        public static string Demo { get { return "http://Demoadmintool.brandmuscle.net/"; } }
        public static string QA { get { return "http://QAadmintool.brandmuscle.net/"; } }
        public static string Dev { get { return "http://Devadmintool.brandmuscle.net/"; } }

        public static string ProductionQAAutomation { get { return "https://qaautomation.brandmuscle.net/Login/Login.aspx";  } }
        public static string ProductionDirecTV { get { return "https://directvmarketingcenter.brandmuscle.net/Login/Login.aspx"; } }
        public static string URLByEnvironment(Environments env)
        {
            switch (env)
            {
                case Environments.Production:
                    return Production; 
                case Environments.Demo:
                    return Demo;
                case Environments.QA:
                    return QA;
                case Environments.Dev:
                    return Dev;
                case Environments.ProductionQAAutomation:
                    return ProductionQAAutomation;
            }
            return null;
        }

    }
}
