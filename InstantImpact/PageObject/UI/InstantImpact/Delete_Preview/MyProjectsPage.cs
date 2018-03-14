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
        public static By MyProject
        { get { return (By.Id("MyProjectsHeader")); } }

//Comment
        public static By SelectAll
        { get { return (By.Id("Body_btnSelectAll")); } }

        public static By SelectNone
        { get { return (By.Id("Body_btnSelectNone")); } }

        public static By DeleteSelected
        { get { return (By.Id("Body_btnDeleteSelected")); } }

        public static By SortByDesignName
        { get { return (By.XPath("//*[@class='t-font-icon rgIcon rgSortAscIcon']")); } }

        public static By SortByTemplateId
        { get { return (By.XPath("//*[@class='t-font-icon rgIcon rgSortAscIcon']")); } }

        public static By SortByTemplateName
        { get { return (By.XPath("//*[@class='t-font-icon rgIcon rgSortAscIcon']")); } }

        public static By AllDesignName
        { get { return (By.XPath("//*[@class='TdDesignName']")); } }

        public static By FirstPreview
        { get { return (By.Id("ctl00_Body_RadGridTemplate_ctl00_ctl04_lnkImage")); } }

        public static By FirstTemplateRow
        { get { return (By.XPath("//tbody/tr[1]/td[1]")); } }

        public static By FirstCheckBox
        { get { return (By.XPath("//tbody/tr[1]/td[1]")); } }

        public static By SelectAllCheckBox
        { get { return (By.XPath("//thead/tr/th[1]")); } }

        public static By FirstDelete
        { get { return (By.XPath("//tbody/tr[1]/td[9]/div[3]/a[1]")); } }

        public static By DeleteAlertPopup
        { get { return (By.XPath("//*[@class='rwContent rwExternalContent']")); } }

        public static By DeleteAlertPopupMsg
        { get { return (By.XPath("//*[text()=' Are you sure you want to Delete?']")); } }

        public static By DeleteAlertPopupYes
        { get { return (By.XPath("//*[@class='rwOkBtn'][1]")); } }

        public static By DeleteAlertPopupNo
        { get { return (By.XPath("//*[@class='rwDialogButtons']/button[2]")); } }

        public static By ConfirmationMsgPopup
        { get { return (By.XPath("//*[contains(@id,'RadWindowWrapper_alert')]")); } }

        public static By ConfirmationPopupOk
        { get { return (By.XPath("//*[@class='rwDialogButtons'][1]")); } }

        public static By SecondCheckBox
        { get { return (By.XPath("//tbody/tr[2]/td[1]")); } }

        public static By AllCheckBox
        { get { return (By.XPath("//tbody/tr/td[1]")); } }

        public static By FirstEdit
        { get { return (By.XPath("//tbody/tr[1]/td[9]/div[2]/a[1]")); } }

        public static By ImageCoulmn
        { get { return (By.XPath("//*[@class='rgHeader'][1]")); } }

        public static By TemplateIdColumn
        { get { return (By.XPath("//*[@class='rgHeader'][5]")); } }

        public static void VerifyHomePage()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
                //Check the visiblity of My Project Header
                Wait.WaitVisible(MyProject, 60);
                bool status_of_myprojectheader = MyProject.IsElementDisplayed();
                Console.WriteLine("Status of logo is " + status_of_myprojectheader);

                //Check the status of SelectAll
                Wait.WaitVisible(SelectAll, 60);
                bool status_of_selecteall = MyProject.IsElementEnabled();
                Console.WriteLine("Status of SelectAll is " + status_of_selecteall);

                //Check the status of SelectNone
                Wait.WaitVisible(SelectNone, 60);
                bool status_of_selectnone = MyProject.IsElementEnabled();
                Console.WriteLine("Status of SelectNone is " + status_of_selectnone);

                //Check the status of DeleteSelected
                Wait.WaitVisible(DeleteSelected, 60);
                bool status_of_deleteselected = DeleteSelected.IsElementEnabled();
                Console.WriteLine("Status of SelectNone is " + status_of_deleteselected);
            }
            catch (Exception e)
            {
                logger.Error("Verify home page failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }
        //Verify Maximum tempalet present in a page 
        public static void VerifyTotalTempalteInaPage()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
                IList<IWebElement> pages = Driver.FindElements(By.XPath("//div[@class='rgCurrentPage']/a"));
                for (int i = 0; i < pages.Count; i++)
                {
                    pages[i].Click();
                    IList<IWebElement> templatelist = Driver.FindElements(By.XPath("//tbody/tr"));
                    int total_template_ina_page = templatelist.Count();
                    int max_size = 10;
                    if (total_template_ina_page <= max_size)
                    {
                        Console.WriteLine("Maximum number of templates present in a page meets requirement: 10");
                    }
                    else
                    {
                        logger.Error("Maximum number of templates present in a page does not meet requirement: 10");
                    }
                }

            }
            catch (Exception e)
            {
                logger.Error("Maximum number of template in My Projects Page failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }
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
                    Wait.WaitVisible(DeleteAlertPopupYes, 10);
                    DeleteAlertPopupYes.Click();
                    Wait.WaitVisible(ConfirmationMsgPopup, 10);
                    Console.WriteLine("Confirmation message is " + ConfirmationMsgPopup.GetText());
                    Wait.WaitVisible(ConfirmationPopupOk, 10);
                    ConfirmationPopupOk.Click();
                    Wait.WaitTime(10);
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
        public static void DeleteMultipleTemplates()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
                FirstCheckBox.Click();
                SecondCheckBox.Click();
                DeleteSelected.Click();
                bool status_of_deletealertpopup = DeleteAlertPopup.IsElementDisplayed();
                if (status_of_deletealertpopup)
                {
                    Console.Write("Message from the Delete alert popup is " + DeleteAlertPopupMsg.GetText());
                    DeleteAlertPopupYes.Click();
                }
                else
                {
                    Console.Write("Delete alert pop-up is not comming ");
                }
                Console.WriteLine("Confirmation message is " + ConfirmationMsgPopup.GetText());
                ConfirmationPopupOk.Click();
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
        public static void DeleteAllTemplates()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            try
            {
                SelectAllCheckBox.Click();
                DeleteSelected.Click();
                bool status_of_deletealertpopup = DeleteAlertPopup.IsElementDisplayed();
                if (status_of_deletealertpopup)
                {
                    Console.Write("Message from the Delete alert popup is " + DeleteAlertPopupMsg.GetText());
                    DeleteAlertPopupYes.Click();
                }
                else
                {
                    Console.Write("Delete alert pop-up is not comming ");
                }
                Console.WriteLine("Confirmation message is " + ConfirmationMsgPopup.GetText());
                ConfirmationPopupOk.Click();
                Wait.WaitTime(10);
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
                FirstEdit.Click();
            }
            catch (Exception e)
            {
                logger.Error("Click on edit failed due to : " + e);
                //test.Fail("Click on edit failed.");
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
                Wait.WaitTime(10);
                if (MyProject.IsElementDisplayed())
                {
                    Console.Write("Delete alert popup is successfully dismissed.");
                }
                else
                {
                    Console.Write("Delete alert popup is not successfully dismissed.");
                }
                Wait.WaitTime(5);
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
                Wait.WaitTime(10);
                if (MyProject.IsElementDisplayed())
                {
                    Console.Write("Delete alert popup is successfully dismissed.");
                }
                else
                {
                    Console.Write("Delete alert popup is not successfully dismissed.");
                }
                Wait.WaitTime(5);

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
                Wait.WaitVisible(DeleteAlertPopup, 10);
                Console.Write("Message from the Delete alert popup is " + DeleteAlertPopupMsg.GetText());
                DeleteAlertPopupNo.Click();
                Wait.WaitTime(10);
                if (MyProject.IsElementDisplayed())
                {
                    Console.Write("Delete alert popup is successfully dismissed.");
                }
                else
                {
                    Console.Write("Delete alert popup is not successfully dismissed.");
                }
                Wait.WaitTime(5);
            }
            catch (Exception e)
            {
                logger.Error("Dismiss PopupAll Template failed due to : " + e);
                //**Closing browser
                Driver.Quit();
                throw e;
            }
        }

        //Verify Color of each row in Projects
        public static void VerifyColorOfRow()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof(MyProjectsPage));
            test = Base.extent.CreateTest("GetColorOfRow");
            try
            {
                String rowcolor_before = Driver.FindElement(By.XPath("//tbody/tr[1]/td[1]")).GetCssValue("background-color");
                Console.WriteLine("Color of row before selecting any template is " + rowcolor_before);
                FirstCheckBox.Click();
                Wait.WaitTime(5);
                String rowcolor_after = Driver.FindElement(By.XPath("//tbody/tr[1]/td[1]")).GetCssValue("background-color");
                Console.WriteLine("Color of row after selecting any template is " + rowcolor_after);

                //var p = rowcolor_after.Split(new char[] { ',', ']' });

                //int A = Convert.ToInt32(p[0].Substring(p[0].IndexOf('=') + 1));
                //int R = Convert.ToInt32(p[1].Substring(p[1].IndexOf('=') + 1));
                //int G = Convert.ToInt32(p[2].Substring(p[2].IndexOf('=') + 1));
                //int B = Convert.ToInt32(p[3].Substring(p[3].IndexOf('=') + 1));

                Color color = Color.FromArgb(105,105,105,1);
                int IColor;
                String color_name;
                //from color to string    
                IColor = ColorTranslator.ToWin32(color);
                color_name = IColor.ToString();
                //from string to color    
                IColor = int.Parse(color_name);
                color = ColorTranslator.FromWin32(IColor);

                Console.WriteLine("Color is " + color);
            }
            catch (Exception e)
            {
                test.Fail("Get color of row failed" + e);
            }

        }
    }
}
