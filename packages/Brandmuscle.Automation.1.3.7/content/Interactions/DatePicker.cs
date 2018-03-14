//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using BrandmuscleAutomation.StartUp;
//using System.Threading;

//namespace BrandmuscleAutomation.Interactions
//{
//    public class DatePicker : Base
//    {


//        IWebElement datePicker;
//        List<IWebElement> noOfColumns;
//        List<String> monthList = Arrays.asList("January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December");
//        // Expected Date, Month and Year
//        int expMonth;
//        int expYear;
//        String expDate = null;
//        // Calendar Month and Year
//        String calMonth = null;
//        String calYear = null;
//        Boolean dateNotFound;

//        //           @BeforeTest
//        //public void start()
//        //           {
//        //               Driver = new FirefoxDriver();
//        //               Driver.manage().window().maximize();
//        //               Driver.manage().timeouts().implicitlyWait(20, TimeUnit.SECONDS);
//        //           }

//        //@Test
//        public void pickExpDate() 
//        {

//            Navigation.GoToURL("http://only-testing-blog.blogspot.in/2014/09/selectable.html");
//            Driver.FindElement(By.XPath("//input[@id='datepicker']")).click();
//            dateNotFound = true;

//            //Set your expected date, month and year.  
//            expDate = "18";
//            expMonth = 8;
//            expYear = 2013;

//            //This loop will be executed continuously till dateNotFound Is true.
//            while (dateNotFound)
//            {
//                //Retrieve current selected month name from date picker popup.
//                calMonth = Driver.FindElement(By.ClassName("ui-datepicker-month")).getText();
//                //Retrieve current selected year name from date picker popup.
//                calYear = Driver.FindElements(By.ClassName("ui-datepicker-year")).getText();

//                //If current selected month and year are same as expected month and year then go Inside this condition.
//                if (monthList.IndexOf(calMonth) + 1 == expMonth && (expYear == Integer.parseInt(calYear)))
//                {
//                    //Call selectDate function with date to select and set dateNotFound flag to false.
//                    selectDate(expDate);
//                    dateNotFound = false;
//                }
//                //If current selected month and year are less than expected month and year then go Inside this condition.
//                else if (monthList.IndexOf(calMonth) + 1 < expMonth && (expYear == Integer.parseInt(calYear)) || expYear > Integer.parseInt(calYear))
//                {
//                    Driver.FindElement(By.XPath(".//*[@id='ui-datepicker-div']/div/a[2]/span")).click();
//                }
//                //If current selected month and year are greater than expected month and year then go Inside this condition.
//                else if (monthList.IndexOf(calMonth) + 1 > expMonth && (expYear == Integer.parseInt(calYear)) || expYear < Integer.parseInt(calYear))
//                {
//                    Driver.FindElement(By.XPath(".//*[@id='ui-datepicker-div']/div/a[1]/span")).click();
//                }
//            }
//            Thread.Sleep(3000);
//            }


// public void selectDate(String date)
//        {
//            datePicker = Driver.FindElement(By.Id("ui-datepicker-div"));
//           List<IWebElement> noOfColumns = datePicker.FindElements(By.TagName("td"));

//            //Loop will rotate till expected date not found.
//            foreach (IWebElement cell in noOfColumns)
//            {
//                //Select the date from date picker when condition match.
//                if (cell.getText().equals(date))
//                {
//                    cell.FindElement(By.linkText(date)).click();
//                    break;
//                }
//            }
//        }
//    }
//}
//}
