using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrandmuscleAutomation.StartUp;
using BrandmuscleAutomation.Interactions;
using log4net;
using log4net.Repository.Hierarchy;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using OpenQA.Selenium.Interactions;
using System.Drawing;

namespace InstantImpact.PageObject.UI.InstantImpact.Delete_Preview
{
    public class MyProjectsPage : Base
    {
        public static ExtentTest test;
        public static By ProjectsHeader
        { get { return (By.XPath("//*[@class='row no-gutters standardHeader']")); } }

        public static By MyProject
        { get { return (By.XPath("//*[@href='/Account/MyProjectsPage.aspx']")); } }

        public static By SearchButton
        { get { return (By.XPath("//*[@name='ctl00$Body$btnSearch']")); } }

        public static By NextPage
        { get { return (By.XPath("//*[@value=' '][3]")); } }

        public static By SearchBox
        { get { return (By.XPath("//*[@id='Body_TxtSearch']")); } }

        public static By SelectAll
        { get { return (By.XPath("//*[contains(text(),'Select All')]")); } }

        public static By SelectNone
        { get { return (By.XPath("//*[contains(text(),'Select None')]")); } }

        public static By DeleteSelected
        { get { return (By.Id("Body_btnDeleteSelected")); } }

        public static By WithoutSelectDeleteAlert
        { get { return (By.XPath("//*[contains(text(),'Please select at least one')]")); } }

        public static By SortByDesignName
        { get { return (By.XPath("//*[@class='rgHeader'][4]/a")); } }

        public static By SortByTemplateId
        { get { return (By.XPath("//*[@class='t-font-icon rgIcon rgSortAscIcon']")); } }

        public static By SortByTemplateName
        { get { return (By.XPath("//*[@class='t-font-icon rgIcon rgSortAscIcon']")); } }

        public static By AllDesignName
        { get { return (By.XPath("//*[@class='TdDesignName']")); } }

        public static By FirstPreview
        { get { return (By.XPath("//*[@id='ctl00_Body_RadGridTemplate_ctl00_ctl04_lnkPreviewImageEnabled']")); } }

        public static By FirstTemplateRow
        { get { return (By.XPath("//tbody/tr[1]/td[1]")); } }

        public static By FirstCheckBox
        { get { return (By.XPath("//tbody/tr[1]/td[1]")); } }

        public static By FirstRow
        { get { return (By.XPath("//tbody/tr[1]/td[1]")); } }

        public static By SelectAllCheckBox
        { get { return (By.XPath("//thead/tr/th[1]")); } }

        public static By FirstDelete
        { get { return (By.XPath("//*[@id='ctl00_Body_RadGridTemplate_ctl00_ctl04_lnkDeleteDesignEnabled']")); } }

        public static By DeleteAlertPopup
        { get { return (By.XPath("//*[contains(@id,'confirm1522')]")); } }

        public static By DeleteAlertPopupMsg
        { get { return (By.XPath("//*[contains(text(),'Are you sure you want to delete')]")); } }

        public static By DeleteAlertPopupYes
        { get { return (By.XPath("//*[@class='boxes'][1]/a[1]")); } }

        public static By DeleteAlertPopupNo
        { get { return (By.XPath("//*[@class='boxes'][1]/a[2]")); } }

        public static By ConfirmationMsgPopup
        { get { return (By.XPath("//*[@id='ctl00_Body_ucMB_ucRadNotification_C_radNotifyTextWrapper']")); } }

        public static By SecondCheckBox
        { get { return (By.XPath("//tbody/tr[2]/td[1]")); } }

        public static By AllCheckBox
        { get { return (By.XPath("//tbody/tr/td[1]")); } }

        public static By FirstEdit
        { get { return (By.XPath("//*[@id='ctl00_Body_RadGridTemplate_ctl00_ctl04_lnkEdit']")); } }

        public static By ImageCoulmn
        { get { return (By.XPath("//*[@class='rgHeader'][1]")); } }

        public static By TemplateIdColumn
        { get { return (By.XPath("//*[@class='rgHeader'][5]")); } }

        public static By AddToKart
        { get { return (By.XPath("//*[@id='ctl00_Body_RadGridTemplate_ctl00_ctl04_lnkAddToCart']"));} }

        public static By YesAlertPopup
        { get { return (By.XPath("//*[@class='btn GenericRedButton'][1]")); } }

        public static By Share
        { get { return (By.XPath("//*[@id='ctl00_Body_RadGridTemplate_ctl00_ctl04_lnkShare']")); } }

        public static By PosOnDemand
        { get { return (By.XPath("//*[@class='MenuItems']/div/div/ul/li[2]")); } }

        public static By FirstDesignname
        { get { return (By.XPath("//tbody/tr[1]/td[5]")); } }

        public static By BeforeTemplates
        { get { return (By.XPath("//tbody/tr/td[5]")); } }

        public static By TemplateId
        { get { return (By.XPath("//tbody/tr[1]/td[6]")); } }

        public static By AfterTemplates
        { get { return (By.XPath("//*[@class='rgSorted']")); } }

        public static By AddToCart
        { get { return (By.XPath("//*[@class='cartImage']")); } }

        public static void VerifyProjectsPage()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
                //Check the visiblity of My Project Header
                Wait.WaitVisible(ProjectsHeader,60);
                bool status_of_myprojectheader = ProjectsHeader.IsElementDisplayed();
                Console.WriteLine("Status of logo is " + status_of_myprojectheader);

                //Check the status of SelectAll
                Wait.WaitVisible(SelectAll, 60);
                bool status_of_selecteall = ProjectsHeader.IsElementEnabled();
                Console.WriteLine("Status of SelectAll is " + status_of_selecteall);

                //Check the status of SelectNone
                Wait.WaitVisible(SelectNone, 60);
                bool status_of_selectnone = ProjectsHeader.IsElementEnabled();
                Console.WriteLine("Status of SelectNone is " + status_of_selectnone);

                //Check the status of DeleteSelected
                Wait.WaitVisible(DeleteSelected, 60);
                bool status_of_deleteselected = DeleteSelected.IsElementEnabled();
                Console.WriteLine("Status of DeleteSelected is " + status_of_deleteselected);
            }
            catch (Exception e)
            {
                logger.Error("Verify home page failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Delete Single Template
        public static void DeleteSingleTemplate()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
                //Delete Single Template
                FirstCheckBox.Click();
                FirstDelete.Click();
                Wait.WaitVisible(DeleteAlertPopup, 10);
                if (DeleteAlertPopup.IsElementDisplayed())
                {
                    Console.Write("Message from the Delete alert popup is " + DeleteAlertPopupMsg.GetText());
                    Wait.WaitVisible(DeleteAlertPopupYes,10);
                    DeleteAlertPopupYes.Click();
                    Wait.WaitVisible(ConfirmationMsgPopup,10);
                    Console.WriteLine("Confirmation message is " + ConfirmationMsgPopup.GetText());
                }
                else
                {
                    Console.Write("Delete alert pop-up is not comming ");
                }
            }
            catch (Exception e)
            {
                logger.Error("Delete Single Template failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }

        }

        //Delete Multiple Templates
        public static void DeleteMultipleTemplates()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
                FirstCheckBox.Click();
                SecondCheckBox.Click();
                DeleteSelected.Click();
                Wait.WaitVisible(DeleteAlertPopup, 10);
                if (DeleteAlertPopup.IsElementDisplayed())
                {
                    Console.Write("Message from the Delete alert popup is " + DeleteAlertPopupMsg.GetText());
                    DeleteAlertPopupYes.Click();
                }
                else
                {
                    Console.Write("Delete alert pop-up is not comming ");
                }
                Console.WriteLine("Confirmation message is " + ConfirmationMsgPopup.GetText());
                Wait.WaitTime(10);
            }
            catch (Exception e)
            {
                logger.Error("Delete Multiple Template failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }

        }

        //Delete All Templates
        public static void DeleteAllTemplates()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
                SelectAllCheckBox.Click();
                DeleteSelected.Click();
                bool status_of_deletealertpopup = DeleteAlertPopup.IsElementDisplayed();
                Assert.IsTrue(status_of_deletealertpopup);
                Wait.WaitVisible(ConfirmationMsgPopup, 10);
                Console.WriteLine("Confirmation message is " + ConfirmationMsgPopup.GetText());
            }
            catch (Exception e)
            {
                logger.Error("Delete All Template failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on Edit Button.
        public static void ClickOnEdit()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
                Wait.WaitVisible(FirstCheckBox, 10);
                FirstEdit.Click();
            }
            catch (Exception e)
            {
                logger.Error("Click on edit failed due to : " + e);
                test.Fail("Click on edit failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on Preview Button
        public static void ClickOnPreview()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("ClickOnPreview");
            try
            {
                FirstPreview.Click();
                Wait.WaitForPageToLoad();
                Get.Windowhandle();
            }
            catch (Exception e)
            {
                logger.Error("Click on preview failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Verify Retired Template
        public static void VerifyRetiredTemplate()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("VerifyRetiredTemplate");
            try
            {
                FirstPreview.Click();
                Wait.WaitForPageToLoad();
                Get.Windowhandle();
            }
            catch (Exception e)
            {
                logger.Error("Verify Retired Template failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Verify Template Id In Create Design Page
        public static string VerifyTemplateId()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("VerifyTemplateId");
            try
            {
                string template_id = TemplateId.GetText();
                // Write the generic code to compare with other related pages(Create Design nad Shopping cart)
                return template_id;
            }
            catch (Exception e)
            {
                logger.Error("Verify Retired Template failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on DeleteSelected without Clicking on Checkbox
        public static void ClickDeleteSelectWithoutCheck()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("DismissPopupSingleTemplate");
            try
            {
                DeleteSelected.Click();
                Wait.WaitVisible(WithoutSelectDeleteAlert,20);
                string msg=WithoutSelectDeleteAlert.GetText();
                Console.WriteLine("Message after click on DeleteSelected without selcting check box is " + msg);
            }
            catch(Exception e)
            {
                logger.Error("Click Delete Select Without Check failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }
        
        //Negative Cases For Delete
        public static void DismissPopupSingleTemplate()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("DismissPopupSingleTemplate");
            try
            {
               
                FirstCheckBox.Click();
                FirstDelete.Click();
                Wait.WaitVisible(DeleteAlertPopup, 10);
                Console.Write("Message from the Delete alert popup is " + DeleteAlertPopupMsg.GetText());
                DeleteAlertPopupNo.Click();
                Assert.IsTrue(ProjectsHeader.IsElementDisplayed());
            }
            catch (Exception e)
            {
                logger.Error("Click on Cancel button failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }
        public static void DismissPopupMultipleTemplate()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("DismissPopup");
            try
            {
                FirstCheckBox.Click();
                FirstCheckBox.Click();
                SecondCheckBox.Click();
                DeleteSelected.Click();
                Wait.WaitVisible(DeleteAlertPopup, 10);
                Console.Write("Message from the Delete alert popup is " + DeleteAlertPopupMsg.GetText());
                DeleteAlertPopupNo.Click();
                Assert.IsTrue(ProjectsHeader.IsElementDisplayed());
            }
            catch (Exception e)
            {
                logger.Error("Click on Cancel button failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }
        public static void DismissPopupAllTemplate()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("DismissPopupAllTemplate");
            try
            {
                SelectAllCheckBox.Click();
                DeleteSelected.Click();
                Wait.WaitVisible(DeleteAlertPopup,10);
                Console.Write("Message from the Delete alert popup is " + DeleteAlertPopupMsg.GetText());
                DeleteAlertPopupNo.Click();
                Assert.IsTrue(ProjectsHeader.IsElementDisplayed());
            }
            catch (Exception e)
            {
                logger.Error("Dismiss PopupAll Template failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Verify List of templates in Projects page
        public static void VerifyListOfTemplates()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("VerifyListOfTemplates");
            try
            {
                IList<IWebElement> templates = Element.getElements(BeforeTemplates);
                Console.WriteLine("Number of templates present in a page is " + templates.Count);
                for (int i = 0; i < templates.Count; i++)
                {
                    Console.WriteLine("Design name is " + templates[i].Text);                    
                }
            }
            catch (Exception e)
            {
                test.Fail("Verify List of template failed" + e);
                Driver.Quit();
                throw e;
            }
        }

        //Filter By Design name
        public static void FilterByDeisgnName()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("VerifyListOfTemplates");
            try
            {
                IList<IWebElement> templates = Element.getElements(BeforeTemplates);
                Console.WriteLine("Number of templates present in a page is " + templates.Count());
                for (int i = 0; i < templates.Count; i++)
                {
                    SearchBox.Type(templates[i].Text);
                    Wait.WaitVisible(SearchButton);
                    SearchButton.Click();
                    SearchBox.Type(Keys.Control + "a");
                    SearchBox.Type(Keys.Clear);
                    MyProject.Click();
                    if (i==0)
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                test.Fail("Filter by deisgn name failed" + e);
                Driver.Quit();
                throw e;
            }
        }

        //Get The Existing design name
        public static string GetExistingName()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("GetExistingName");
            try
            {
                Wait.WaitVisible(FirstDesignname,10);
                string before_template = FirstDesignname.GetText();
                Console.WriteLine("Temaplate Design name is " + before_template);
                return before_template;
            }
            catch (Exception e)
            {
                logger.Error("Get Existing Name failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Verify Sorting By Design name
        public static void VerifySortByDesignName()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("VerifySortByDesignName");
            try
            {
                //Before click on Sort by Design name
                IList<IWebElement> before_templates = Element.getElements(BeforeTemplates);
                Console.WriteLine("Design names before sorting..");
                foreach(IWebElement beforeclick in before_templates)
                {
                    Console.WriteLine(beforeclick.Text);
                }
                SortByDesignName.Click();
                //After click on Sort by Design name
                Console.WriteLine("Design names after sorting..");
                IList<IWebElement> after_templates = Element.getElements((AfterTemplates));
                foreach (IWebElement afterclick in after_templates)
                {
                    Console.WriteLine(afterclick.Text);
                }
            }
            catch (Exception e)
            {
                test.Fail("Verify List of Verify Soft by deisgn name failed" + e);
                Driver.Quit();
                throw e;
            }
        }

        //Share Templates
        public static void ClickOnShare()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("Click on Share");
            try
            {
                Wait.WaitVisible(Share);
                Share.Click();
            }
            catch(Exception e)
            {
                test.Fail("Share Template failed" + e);
                Driver.Quit();
                throw e;
            }
        }

        //Click on Add to Kart
        public static void ClickOnAddtoKart()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
                AddToKart.Click();
                YesAlertPopup.Click();
            }
            catch (Exception e)
            {
                logger.Error("Click on add to kart failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on POS On Demand Button
        public static void ClickOnPosOnDemand()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
                Wait.WaitVisible(PosOnDemand,10);
                PosOnDemand.Click(); 
            }
            catch (Exception e)
            {
                logger.Error("ClickOnPosOnDemand failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Click on Shopping Cart
        public static void ClickOnShoppingCart()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
                Wait.WaitVisible(AddToCart);
                AddToCart.Click();
            }
            catch (Exception e)
            {
                test.Fail("Share Template failed" + e);
                Driver.Quit();
                throw e;
            }
        }

        //Verify for Unavailable and Click on Edit Button.
        public static void VerifyAndClickOnEdit()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
               
            }
            catch (Exception e)
            {
                logger.Error("Click on edit failed due to : " + e);
                test.Fail("Click on edit failed.");
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }
    }
}
