using BrandmuscleAutomation.Enum;
using System;

namespace BrandmuscleAutomation.StartUp
{
    class AdminURLS
    {
        public static string ProductionQAAutomation { get { return "http://admintool.brandmuscle.net/"; } }
        public static string Demo { get { return "http://Demoadmintool.brandmuscle.net/"; } }
        public static string QA { get { return "http://QAadmintool.brandmuscle.net/"; } }
        public static string Dev { get { return "http://Devadmintool.brandmuscle.net/"; } }


        public static string URLByEnvironment(Environments env)
        {
            switch (env)
            {
                case Environments.ProductionQAAutomation:
                    return ProductionQAAutomation; 
                case Environments.Demo:
                    return Demo;
                case Environments.QA:
                    return QA;
                case Environments.Dev:
                    return Dev;             
            }
            return null;
        }

    }
}
