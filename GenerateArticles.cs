namespace WikiBot
{
    using System;
    using System.Data;
    using System.Threading;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.TestTemplates;
    using ClosedXML.Excel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GenerateArticles : BaseTest
    {
        private const string Url = "https://tools.wmflabs.org/templatetiger/tt-table4.php?lang=enwiki&template=taxobox";
        private const string SheetName = "Taxobox";
        private const string FilePath = "../../../Templates/";

        private const int Start = 0;
        private const int End = int.MaxValue;
        private const int Lines = 100;
        private const int Period = 10000;
        private const int SleepTime = 10000;

        public TestContext TestContext { get; set; }
        public DataTable DataTable { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            this.Initialize(false, this.TestContext.TestLogsDir, new TestContextWriteLine(this.TestContext.WriteLine));
            this.SetTestMethod(this, (string)TestContext.Properties["TestName"]);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.CleanUp();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            ShutDown();
        }

        [TestMethod]
        public void ExportEnTaxoboxTemplateToExcel()
        {
            Manager.LaunchNewBrowser(BrowserType.InternetExplorer);
            ActiveBrowser.NavigateTo(Url + "&offset=" + Start + "&limit=" + Lines);
            this.CreateTable();

            for (int count = Start + 1; count < End; count++)
            {
                this.ExtractTable();

                if ((((count - Start) * Lines) + Start) % Period == 0)
                {
                    int realCount = (count - Start) * Lines + Start;
                    this.ExportToExcel(FilePath + "Templates (" + (realCount - Period + 1) + "-" + realCount + ").xlsx");
                    this.CreateTable();
                }

                // Go to the next page
                var next = Find.ByContent<HtmlAnchor>(">>>");
                if (next != null) next.Click();
                else break;
            }

            this.ExportToExcel(FilePath + "Templates.xlsx");
        }

        // Create new empty data table
        private void CreateTable()
        {
            this.DataTable = new DataTable();
            this.DataTable.Clear();
            Thread.Sleep(SleepTime);
        }

        // Take all table's data from the current web page
        private void ExtractTable()
        {
            HtmlTable table = Find.ByXPath<HtmlTable>("//html/body/table");
            var cells = table.Rows[0].Cells;
            for (int c = 0; c < cells.Count; c++)
            {
                var currentColumnName = cells[c].InnerText == string.Empty ? "link" : cells[c].InnerText;
                if (!this.DataTable.Columns.Contains(currentColumnName))
                {
                    this.DataTable.Columns.Add(currentColumnName);
                }
            }

            var rows = table.Rows;
            for (int r = 1; r < rows.Count; r++)
            {
                DataRow dataRow = this.DataTable.NewRow();
                for (int c = 0; c < cells.Count; c++)
                {
                    dataRow[cells[c].InnerText == string.Empty ? "link" : cells[c].InnerText] = rows[r][c].InnerText;
                }

                this.DataTable.Rows.Add(dataRow);
            }
        }

        // Export all data to an Excel file
        private void ExportToExcel(string filePath)
        {
            XLWorkbook workbook = new XLWorkbook();
            workbook.Worksheets.Add(this.DataTable, SheetName);
            workbook.SaveAs(filePath);
        }
    }
}