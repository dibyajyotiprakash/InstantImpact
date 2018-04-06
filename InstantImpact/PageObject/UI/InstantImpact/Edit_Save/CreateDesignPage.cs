using System;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Interactions;
using log4net;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        { get { return (By.XPath("//i[contains(text(),'save')]")); } }

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

        public static By YesSaveInSaveDesignPopup
        { get { return (By.XPath("//*[@id='ctl00_Body_rwSaveDesignModal_C_btnDesignSave']")); } }

        public static By DesignName
        { get { return (By.Id("ctl00_Body_rwSaveDesignModal_C_txtDesignName")); } }

        public static By SaveDesignNameYes
        { get { return (By.XPath("//*[@id='ctl00_Body_rwSaveDesignModal_C_btnDesignSave']")); } }

        public static By SaveDesignNameNo
        { get { return (By.XPath("//*[@id='ctl00_Body_rwSaveDesignModal_C_btnCancelDesignSave']")); } }

        public static By SaveDesignNameConfirmMsg
        { get { return (By.Id("ctl00_Body_ucMBTwo_ucRadNotification_C_radNotifyTextWrapper")); } }

        public static By NextStep
        { get { return (By.Id("btnNextStep")); } }

        public static By SaveDeisgnPopup
        { get { return (By.Id("ctl00_Body_rwSaveDesignModal_C")); } }

        public static By YesInOverWritePopup
        { get { return (By.XPath("//*[@id='ctl00_Body_rwSelectAlternate_C_btnAccept']")); } }

        public static By NoInOverWritePopup
        { get { return (By.XPath("//*[@id='ctl00_Body_rwSelectAlternate_C_btnDeny']")); } }

        public static By YesFromCancelCreateDesignPopup
        { get { return (By.XPath("(//*[@class='btn GenericRedButton'])[1]")); } }

        public static By NoFromCancelCreateDesignPopup
        { get { return (By.XPath("(//*[@class='btn GenericRedButton'])[2]")); } }

        public static By NoFromNext
        { get { return (By.XPath("//*[@class='boxes']/a[2]")); } }

        public static By YesFromNext
        { get { return (By.XPath("//*[@class='boxes']/a[1]")); } }

        public static By Loader
        { get { return (By.XPath("//*[@src='/Content/Images/loading.gif']")); } }

        public static By MyProject
        { get { return (By.Id("MyProjectsHeader")); } }

        public static By OverwriteFromEdit
        { get { return (By.XPath("//*[@id='ctl00_Body_rwSelectOption_C_btnOverwrite']")); } }

        public static By SaveAsNewFromEdit
        { get { return (By.XPath("//*[@id='ctl00_Body_rwSelectOption_C_btnSaveAsNew']")); } }

        //Verify Create Design Page
        public static void VerifyCreateDesignPage()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitForPageToLoad();
                Wait.WaitVisible(CreateDesignHeader);
                bool status_of_createdesignlogo = CreateDesignHeader.IsElementDisplayed();
                Console.WriteLine("Status of create design header is " + status_of_createdesignlogo);
                logger.Info("Status of create design header is " + status_of_createdesignlogo);
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
            try
            {
                Wait.WaitVisible(PreviewChanges,20);
                PreviewChanges.Click();
                Wait.WaitVisible(PreviewImage,20);
                bool status_of_previewimage = PreviewImage.IsElementDisplayed();
                logger.Info("Status of Preview Image is " + status_of_previewimage);
                Console.WriteLine("Status of Preview Image is " + status_of_previewimage);
                //Wait.WaitVisible(SaveDesign);
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
            try
            {
                Wait.WaitVisible(ViewProof,20);
                ViewProof.Click();
                Get.Windowhandle();
                Wait.WaitVisible(PreviewChanges,30);
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

        //Give design name in Save Design Popup
        public static void VerifySaveDesign(string name)
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(SaveDesign,20);
                SaveDesign.Click();
                Wait.WaitVisible(SaveDeisgnPopup,20);
                ClearTextInSaveDesignPopup();
                string designnanme = name + DateTime.Now.ToString();
                DesignName.Type(designnanme);
                Wait.WaitVisible(SaveDesignNameYes,10);
                SaveDesignNameYes.Click();
                Wait.WaitVisible(SaveDesignNameConfirmMsg,20);
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
            try
            {
                Wait.WaitVisible(NextStep,20);
                NextStep.Click();
                test.Pass("Click on next step passed.");
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

        //Click on Cancel in Create Deisgn page
        public static void ClickOnCancel()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Clicks.ScrollToViewElement(CreateDesignCancel);
                Wait.WaitVisible(CreateDesignCancel, 10);
                CreateDesignCancel.Click();
                test.Pass("Click on Cancel passed.");
            }
            catch (Exception e)
            {
                Console.Write("Click On Cancel failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on Yes Coming from Cancel in Create Deisgn page
        public static void ClickOnYesFromCancel()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(YesFromCancelCreateDesignPopup,10);
                YesFromCancelCreateDesignPopup.Click();
                test.Pass("Yes From Cancel Create Design Popup passed.");
            }
            catch (Exception e)
            {
                Console.Write("Click On Cancel failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on No From Cancel Create Design Page
        public static void ClickOnNoFromCancel()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(NoFromCancelCreateDesignPopup,10);
                NoFromCancelCreateDesignPopup.Click();
                test.Pass("No From Cancel Create Design Popup passed.");
            }
            catch (Exception e)
            {
                Console.Write("No From Cancel Create Design Popup failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on Save Design in Create Deisgn page
        public static void OverWriteExistingNameWithYes()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(SaveDesign,30);
                SaveDesign.Click();
                Wait.WaitVisible(YesSaveInSaveDesignPopup, 10);
                YesSaveInSaveDesignPopup.Click();
                YesInOverWritePopup.Click();
            }
            catch (Exception e)
            {
                Console.Write("Click On Save failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on Yes on OverWrite popup in Create Deisgn page
        public static void ClickOnYesInOverWritePopup()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(YesInOverWritePopup, 20);
                YesInOverWritePopup.Click();
                test.Pass("Click on yes passed.");
            }
            catch (Exception e)
            {
                Console.Write("Click On yes failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on No on OverWrite popup in Create Deisgn page
        public static void ClickOnNoInOverWritePopup()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(NoInOverWritePopup,20);
                NoInOverWritePopup.Click();
                test.Pass("Click on no passed.");
            }
            catch (Exception e)
            {
                Console.Write("Click On no failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Clear Text field in save design name
        public static void ClearTextInSaveDesignPopup()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(DesignName,30);
                DesignName.Type(Keys.Control + "a");
                DesignName.Type(Keys.Clear);
            }
            catch (Exception e)
            {
                Console.Write("Clear Text In Save DesignPopup failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on No on Confirmation popup in Create Deisgn page after click on Next
        public static void ClickOnNoFromNextStep()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(NoFromNext,10);
                NoFromNext.Click();
                test.Pass("Click on no passed.");
            }
            catch (Exception e)
            {
                Console.Write("Click On no failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on Yes on Confirmation popup in Create Deisgn page after click on Nex
        public static void ClickOnYes()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(YesFromNext,10);
                YesFromNext.Click();
                test.Pass("Click on no passed.");
            }
            catch (Exception e)
            {
                Console.Write("Click On no failed.");
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
            try
            {
                CreateDesignCancel.Click();
                Wait.WaitVisible(CancelDesignPopupOk,10);
                CancelDesignPopupOk.Click();
                Assert.IsTrue(MyProject.IsElementDisplayed());
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
            try
            {
                if (SaveDesign.IsElementEnabled())
                {
                    SaveDesign.Click();
                    bool status_of_save_button = SaveDesignNameYes.IsElementEnabled();
                    Console.WriteLine("Status of save design button is " + status_of_save_button);
                    logger.Info("Status of save design button is " + status_of_save_button);
                    Wait.WaitVisible(SaveDeisgnPopup,20);
                    String designnanme = name + DateTime.Now.ToString();
                    DesignName.Type(designnanme);
                    SaveDesignNameNo.Click();
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
            try
            {
                bool status_viewproof_before = ViewProof.IsElementDisplayed();
                Console.WriteLine("Status of view proof before cliking on Preview changes " + status_viewproof_before);
                Wait.WaitVisible(PreviewChanges, 30);
                VerifyPreviewChanges();
                Wait.WaitVisible(ViewProof,10);
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
            try
            {
                SaveDesign.Click();
                Wait.WaitVisible(SaveDeisgnPopup, 30);
                Wait.WaitVisible(DesignName, 10);
                DesignName.Type("suresh");
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

        //Click on OverWriteFromEdit
        public static void OverWriteFromEdit()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                OverwriteFromEdit.Click();
                test.Pass("OverWrite From Edit passed.");
            }
            catch (Exception e)
            {
                logger.Error("Over Write From Edit failed due to : " + e);
                test.Fail("Over Write From Edit failed");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on SaveAsNewFromEdit
        public static void SaveasNewFromEdit()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(SaveAsNewFromEdit,10);
                SaveAsNewFromEdit.Click();
                test.Pass("OverWrite From Edit passed.");
            }
            catch (Exception e)
            {
                logger.Error("Over Write From Edit failed due to : " + e);
                test.Fail("Over Write From Edit failed");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Verify Confirmation Message
        public static void VerifyConfirmationMsg()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(SaveDesignNameConfirmMsg,20);
                String msg = SaveDesignNameConfirmMsg.GetText();
            }
            catch (Exception e)
            {
                logger.Error("Verify Confirmation Msg failed due to : " + e);
                test.Fail("Verify Confirmation Msg failed");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Give New Design name in Save Design Popup from edit
        public static void SaveDesignWithNewName(string name)
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                string designnanme = name + DateTime.Now.ToString();
                Wait.WaitVisible(DesignName,10);
                DesignName.Type(designnanme);
                Wait.WaitVisible(SaveDesignNameYes,20);
                SaveDesignNameYes.Click();
            }
            catch (Exception e)
            {
                logger.Error("Save Design With New Name failed due to : " + e);
                test.Fail("Save Design With New Name failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Give the Existing design name
        public static void GiveExistingName(string name)
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(DesignName, 10);
                DesignName.Type(name);
            }
            catch (Exception e)
            {
                logger.Error("Give Existing Name failed due to : " + e);
                test.Fail("Give Existing Name failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Give the Existence of Save DesignPopup
        public static void VerifyExistenceOfSaveDesignPopup()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(CreateDesignPage));
            try
            {
                Wait.WaitVisible(SaveDeisgnPopup, 10);
                bool status_of_savedesignpopup=SaveDeisgnPopup.IsElementDisplayed();
                Console.WriteLine("Status of save design popup is " + status_of_savedesignpopup);
            }
            catch (Exception e)
            {
                logger.Error("Give Existing Name failed due to : " + e);
                test.Fail("Give Existing Name failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }
    }
}