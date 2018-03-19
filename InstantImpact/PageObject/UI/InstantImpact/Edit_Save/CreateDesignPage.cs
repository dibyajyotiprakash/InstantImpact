using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Interactions;
using log4net;
using OpenQA.Selenium;
using AventStack.ExtentReports;

namespace InstantImpact.PageObject.UI.InstantImpact.Edit_Save
{
    public class CreateDesignPage : Base
    {
        public static ExtentTest test;
        public static By CreateDesignHeader
        { get { return (By.XPath("//h1[contains(text(),'Create Your Design')]")); } }

        public static By CreateDesignCancel
        { get { return (By.XPath("//*[@id='Body_CancelButton']")); } }

        public static By CancelDesignPopup
        { get { return (By.XPath("//*[contains(@id,'confirm1521')]")); } }

        public static By CancelDesignPopupOk
        { get { return (By.XPath("//*[@class='rwOkBtn'][1]")); } }

        public static By CancelDesignPopupCancel
        { get { return (By.XPath("//*[@value='Cancel']")); } }

        public static By PreviewChanges
        { get { return (By.Id("Body_repaintImageTopButton")); } }

        public static By SaveDesign
        { get { return (By.Id("Body_lnkSaveDesign")); } }

        public static By ExistingDesignNameMsg
        { get { return (By.XPath("//*[text()='Design name exists, please re-try.']")); } }

        public static By ViewProof
        { get { return (By.Id("Body_lnkDownload")); } }

        public static By ChooesLayOut
        { get { return (By.Id("Body_ddlChooseLayout")); } }

        public static By ChooseDrinkOne
        { get { return (By.Id("Body_ddlChooseDrinkOne")); } }

        public static By PriceOne
        { get { return (By.Id("Body_txtQTPrice One")); } }

        public static By ChooseDrinkTwo
        { get { return (By.Id("Body_ddlChooseDrinkTwo")); } }

        public static By PriceTwo
        { get { return (By.Id("Body_txtQTPrice Two")); } }

        public static By ChooseDrinkThree
        { get { return (By.Id("Body_ddlChooseDrinkThree")); } }

        public static By PriceThree
        { get { return (By.Id("Body_txtQTPrice Three")); } }

        public static By PreviewImage
        { get { return (By.Id("imgProof")); } }

        public static By SaveDesignName
        { get { return (By.Id("ctl00_Body_rwSaveDesignModal_C_txtDesignName")); } }

        public static By SaveDesignNameYes
        { get { return (By.Id("ctl00_Body_rwSaveDesignModal_C_btnSave")); } }

        public static By SaveDesignNameNo
        { get { return (By.Id("ctl00_Body_rwSaveDesignModal_C_btnCancel")); } }

        public static By SaveDesignNameConfirmMsg
        { get { return (By.Id("ctl00_Body_ucMBTwo_ucRadNotification_C_radNotifyTextWrapper")); } }

        public static By NextStep
        { get { return (By.Id("btnNextStep")); } }

        public static By SaveDeisgnPopup
        { get { return (By.Id("ctl00_Body_rwSaveDesignModal_C")); } }

        public static By Loader
        { get { return (By.XPath("//*[@src='/Content/Images/loading.gif']")); } }

        public static By MyProject
        { get { return (By.Id("MyProjectsHeader")); } }

        //Verify Create Design Page
        public static void VerifyCreateDesignPage()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            test = extent.CreateTest("VerifyCreateDesignPage");
            try
            {
                Wait.WaitVisible(CreateDesignHeader, 30);
                bool status_of_createdesignlogo = CreateDesignHeader.IsElementDisplayed();
                Console.WriteLine("Status of create design header is " + status_of_createdesignlogo);
                logger.Info("Status of create design header is " + status_of_createdesignlogo);
                Wait.WaitTime(30);
            }
            catch (Exception e)
            {
                logger.Error("Verify Create design page failed due to : " + e);
                test.Fail("Verify Create design page failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }

        }

        //Click on Preview Changes
        public static void VerifyPreviewChanges()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            test = extent.CreateTest("VerifyPreviewChanges");
            try
            {
                Wait.WaitVisible(PreviewChanges, 10);
                PreviewChanges.Click();
                Wait.WaitVisible(PreviewImage, 30);
                bool status_of_previewimage = PreviewImage.IsElementDisplayed();
                logger.Info("Status of Preview Image is " + status_of_previewimage);
                Console.WriteLine("Status of Preview Image is " + status_of_previewimage);
                Wait.WaitVisible(SaveDesign, 30);
            }
            catch (Exception e)
            {
                logger.Error("Preview Changes failed due to : " + e);
                test.Fail("Preview Changes failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on View Proof
        public static void VerifyViewProof()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            test = extent.CreateTest("VerifyViewProof");
            try
            {
                PreviewChanges.Click();
                Wait.WaitVisible(ViewProof, 20);
                Wait.WaitTime(20);
                ViewProof.Click();
                Get.Windowhandle();
                Wait.WaitVisible(PreviewChanges, 30);
            }
            catch (Exception e)
            {
                logger.Error("View proof failed due to : " + e);
                test.Fail("View proof failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on Preview Changes
        public static void ClickOnPreviewChange()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            test = extent.CreateTest("ClickOnPreviewChange");
            try
            {
                PreviewChanges.Click();
                test.Pass("ClickOnPreviewChange passed");
            }
            catch (Exception e)
            {
                test.Fail("ClickOnPreviewChange failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on Save Design
        public static void VerifySaveDesign(string name)
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            test = extent.CreateTest("VerifyViewProof");
            try
            {
                Wait.WaitVisible(SaveDesign, 20);
                SaveDesign.Click();
                Wait.WaitVisible(SaveDeisgnPopup, 20);
                string designnanme = name + DateTime.Now.ToString();
                SaveDesignName.Type(designnanme);
                Wait.WaitTime(10);
                SaveDesignNameYes.Click();
                Wait.WaitVisible(SaveDesignNameConfirmMsg, 20);
                String msg = SaveDesignNameConfirmMsg.GetText();
                Console.WriteLine("Confirmation msg after successfully saving the design name " + msg);
                logger.Info("Confirmation msg after successfully saving the design name " + msg);


            }
            catch (Exception e)
            {
                logger.Error("Verify Design name failed due to : " + e);
                test.Fail("Verify Design name failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }

        }

        //Click on NextStep
        public static void ClickOnNextStep()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            test = extent.CreateTest("ClickOnNextStep");
            try
            {
                NextStep.Click();
                test.Pass("Click on next passed.");
            }
            catch (Exception e)
            {
                logger.Error("Cancel Design name pop-up failed due to : " + e);
                test.Fail("Cancel Design name pop-up failed");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Negative Cases for Edit
        public static void CancelCreatedesign()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            test = Base.extent.CreateTest("CancelCreatedesign");
            try
            {
                CreateDesignCancel.Click();
                Wait.WaitTime(40);
                CancelDesignPopupOk.Click();
                Wait.WaitTime(5);
                if (MyProject.IsElementDisplayed())
                {
                    Console.Write("Successfully navigate to " + Driver.Title + " page ");
                }
                else
                {
                    Console.Write("Navigating to Projets page failed.");
                }
                Wait.WaitTime(5);
            }
            catch (Exception e)
            {
                logger.Error("Cancel Createdesign failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }

        }

        //Negative Cases for Save
        public static void CancelSaveDesignName(string name)
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            test = Base.extent.CreateTest("CancelSaveDesignName");
            try
            {
                if (SaveDesign.IsElementEnabled())
                {
                    SaveDesign.Click();
                    bool status_of_save_button = SaveDesignNameYes.IsElementEnabled();
                    Console.WriteLine("Status of save design button is " + status_of_save_button);
                    logger.Info("Status of save design button is " + status_of_save_button);
                    Wait.WaitVisible(SaveDeisgnPopup, 20);
                    String designnanme = name + DateTime.Now.ToString();
                    SaveDesignName.Type(designnanme);
                    Wait.WaitTime(5);
                    SaveDesignNameNo.Click();
                    Wait.WaitTime(5);
                }
                else
                {
                    Console.WriteLine("Cancel SaveDesign Name failed.");
                    logger.Info("Cancel SaveDesign Name failed.");
                }
                if (CreateDesignHeader.IsElementDisplayed())
                {
                    Console.Write("Create Design page is opened.");
                }
                else
                {
                    Console.Write("Navigating to Create Design page failed.");
                }
                Wait.WaitTime(5);
            }
            catch (Exception e)
            {
                logger.Error("Cancel Save DesignName failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }

        }

        //Checking Visiblity of SaveDesign and ViewProof button.
        public static void VerifySaveDesignViewProof()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            test = Base.extent.CreateTest("VerifySaveDesignViewProof");
            try
            {
                bool status_viewproof_before = ViewProof.IsElementDisplayed();
                Console.WriteLine("Status of view proof before cliking on Preview changes " + status_viewproof_before);
                Wait.WaitVisible(PreviewChanges, 30);
                VerifyPreviewChanges();
                Wait.WaitTime(30);
                bool status_viewproof_after = ViewProof.IsElementDisplayed();
                Console.WriteLine("Status of view proof after cliking on Preview changes " + status_viewproof_after);
            }
            catch (Exception e)
            {
                logger.Error("Verify SaveDesign ViewProof failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Verify Alert Msg for Existing Design
        public static void VerifyExistingDesignAlertMsg()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            test = Base.extent.CreateTest("VerifyExistingDesignAlertMsg");
            try
            {
                SaveDesign.Click();
                Wait.WaitVisible(SaveDeisgnPopup, 30);
                Wait.WaitTime(30);
                SaveDesignName.Type("suresh");
                string alert_msg = ExistingDesignNameMsg.GetText();
                Console.WriteLine("For existing design alert msg is " + alert_msg);
            }
            catch (Exception e)
            {
                logger.Error("Verify Existing Design Alert Msg failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }
    }
}