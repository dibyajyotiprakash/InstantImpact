using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace BrandmuscleAutomation.Data
{
    public class ChannelBuilderVariables 
    {
      
        public void CBvariablesMethod(int rcount)
        {

            //*****=========All the varaibles used in automation are stored here==============*****//
            //public string PrgName = "Test";
            //public string prgDesc = "Automation Test";
            //public string StartDate = "01-05-2017";
            //public string EndDate = "28-05-2017";
            //public string ClaimDate = "30-06-2017";
            //public string Accrual = "Rolling-6 months";
            //public string AccrualExpirationdate = "31-07-2017";
            //public string PrgGuidelinePath = "D:\\ForAutomation\\ProgramGuideline.pdf";
            //public string[] ActivityTypeOptions = { "CATALOG", "INSERT-MAGAZINE", "NEWSPAPER" };
            //public string[] Messages = { "Program name is required", "Description is required", "Start Date is required", "End Date is required", "Final date for program transactions is required", "Accrual Type is required", "Program Guideline is required", "Please select activities", "Please fill all reimbursement percentages", "Please fill reimbursement percentage", "Invalid Program Name" };
            ////string ReImbursementType = "Flat";
            //public string ReImbursementType = "Variable";
            //public string[] ReimbursementRate = { "15", "20", "34" };


            string ExcelFilePath = "D:\\ForAutomation\\AddNewProgramDetails.xlsx";
            Excel.Application exlApp;
            Excel.Workbook exlWorkBook;
            Excel.Worksheet exlWorkSheet;
            Excel.Range exlRange;

            //exlApp = new Excel.Application();
            //exlWorkBook = exlApp.Workbooks.Open(@ExcelFilePath);
            //exlWorkSheet = (Excel.Worksheet)exlWorkBook.Worksheets.get_Item(1);
            //exlRange = exlWorkSheet.UsedRange;

            //int exlRowCount = exlRange.Rows.Count;
            //int exlColumnCount = exlRange.Columns.Count;
            int  ccount = 1;
            //for (rcount = 3; rcount <= n; rcount++)
            //{
                //Console.WriteLine("Starting with Program " + (rcount - 2) + " creation");
                //string PrgName = (exlRange.Cells[rcount, ccount] as Excel.Range).Value2;
                //string prgDesc = (exlRange.Cells[rcount, (ccount + 1)] as Excel.Range).Value2;
                //string StartDate = (exlRange.Cells[rcount, (ccount + 2)] as Excel.Range).Value2;
                //string EndDate = (exlRange.Cells[rcount, (ccount + 3)] as Excel.Range).Value2;
                //string ClaimDate = (exlRange.Cells[rcount, (ccount + 4)] as Excel.Range).Value2;
                //string Accrual = (exlRange.Cells[rcount, (ccount + 5)] as Excel.Range).Value2;
                //string AccrualExpirationdate = (exlRange.Cells[rcount, (ccount + 6)] as Excel.Range).Value2;
                //string PrgGuidelinePath = (exlRange.Cells[rcount, (ccount + 7)] as Excel.Range).Value2;
                //string ActivityTypeOptionsExcel = (exlRange.Cells[rcount, (ccount + 8)] as Excel.Range).Value2;
                //string ReImbursementType = (exlRange.Cells[rcount, (ccount + 9)] as Excel.Range).Value2;
                //string ReimbursementRateExcel = (exlRange.Cells[rcount, (ccount + 10)] as Excel.Range).Value2;
                //string[] Messages = { "Program name is required", "Description is required", "Start Date is required", "End Date is required", "Final date for program transactions is required", "Accrual Type is required", "Program Guideline is required", "Please select activities", "Please fill all reimbursement percentages", "Please fill reimbursement percentage", "Invalid Program Name" };
                //string[] ActivityTypeOptions = ActivityTypeOptionsExcel.Split(',');

                //string[] ReimbursementRate = ReimbursementRateExcel.Split(',');

            //}
            }
        }
}