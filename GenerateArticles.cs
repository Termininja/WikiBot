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
        private const string Url = "https://tools.wmflabs.org/templatetiger/tt-table4.php?template=taxobox&lang=enwiki";
        private const string SheetName = "Taxobox";
        private const string FilePath = "../../../Templates/";
        private const int Lines = 10;
        private const int Period = 10000;
        private const int SleepTime = 10000;

        public TestContext TestContext { get; set; }

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
        public void ClassCleanup()
        {
            ShutDown();
        }

        [TestMethod]
        public void ExportEnTaxoboxTemplateToExcel()
        {
            Manager.LaunchNewBrowser(BrowserType.InternetExplorer);
            ActiveBrowser.NavigateTo(Url + "&limit=" + Lines);

            DataTable dataTable = new DataTable();
            dataTable.Clear();

            for (int count = 1; count < int.MaxValue; count++)
            {
                this.ExtractTable(dataTable);

                if ((count * Lines) % Period == 0)
                {
                    int realCount = count * Lines;
                    this.ExportToExcel(dataTable, FilePath + "Templates (" + (realCount - Period) + "-" + realCount + ").xlsx");
                    dataTable.Clear();

                    Thread.Sleep(SleepTime);
                }

                // Go to the next page
                var next = Find.ByContent<HtmlAnchor>(">>>");
                if (next != null) next.Click();
                else break;
            }

            this.ExportToExcel(dataTable, FilePath + "Templates.xlsx");
        }

        // Take all table's data from the current web page
        private void ExtractTable(DataTable dataTable)
        {
            HtmlTable table = Find.ByXPath<HtmlTable>("//html/body/table");
            var cells = table.Rows[0].Cells;
            for (int c = 0; c < cells.Count; c++)
            {
                var currentColumnName = cells[c].InnerText == string.Empty ? "link" : cells[c].InnerText;
                if (!dataTable.Columns.Contains(currentColumnName))
                {
                    dataTable.Columns.Add(currentColumnName);
                }
            }

            var rows = table.Rows;
            for (int r = 1; r < rows.Count; r++)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int c = 0; c < cells.Count; c++)
                {
                    dataRow[cells[c].InnerText == string.Empty ? "link" : cells[c].InnerText] = rows[r][c].InnerText;
                }

                dataTable.Rows.Add(dataRow);
            }
        }

        // Export all data to an Excel file
        private void ExportToExcel(DataTable dataTable, string filePath)
        {
            XLWorkbook workbook = new XLWorkbook();
            workbook.Worksheets.Add(dataTable, SheetName);
            workbook.SaveAs(filePath);
        }
    }
}