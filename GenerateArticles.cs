namespace WikiBot
{
    using System.Data;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.TestTemplates;
    using ClosedXML.Excel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class GenerateArticles : BaseTest
    {
        private const string Url = "https://tools.wmflabs.org/templatetiger/tt-table4.php?template=taxobox&lang=enwiki";
        private const string FilePath = "../../../Templates/";
        private const int NumberOfLines = 10;
        private const int Period = 100;

        public TestContext TestContext { get; set; }

        [TestInitialize()]
        public void MyTestInitialize()
        {
            Initialize(false, this.TestContext.TestLogsDir, new TestContextWriteLine(this.TestContext.WriteLine));
            SetTestMethod(this, (string)TestContext.Properties["TestName"]);
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            this.CleanUp();
        }

        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            ShutDown();
        }

        [TestMethod]
        public void ExportEnTaxoboxTemplateToExcel()
        {
            Manager.LaunchNewBrowser(BrowserType.InternetExplorer);
            ActiveBrowser.NavigateTo(Url + "&limit=" + NumberOfLines);

            DataTable dataTable = new DataTable();
            dataTable.Clear();

            try
            {
                int count = 0;
                while (true)
                {
                    count++;
                    if (ActiveBrowser.AutoWaitUntilReady)
                    {
                        ExtractTable(dataTable);
                    }

                    if ((count * NumberOfLines) % Period == 0)
                    {
                        int realCount = count * NumberOfLines;
                        ExportToExcel(dataTable, "Taxobox", FilePath + "Templates (" + (realCount - Period) + "-" + realCount + ").xlsx");
                        dataTable.Clear();
                    }

                    // Go to the next page
                    var next = Find.ByContent<HtmlAnchor>(">>>");
                    if (next != null) next.Click();
                    else break;
                }

                ExportToExcel(dataTable, "Taxobox", FilePath + "Templates.xlsx");
            }
            catch (Exception ex)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["link"] = "Error: " + ex.ToString();
                dataTable.Rows.Add(dataRow);

                ExportToExcel(dataTable, "Taxobox", FilePath + "Templates (with Errors).xlsx");
            }
        }

        // Take all table's data from the current web page
        private void ExtractTable(DataTable dataTable)
        {
            HtmlTable table = Find.ByXPath<HtmlTable>("//html/body/table");
            var cells = table.Rows[0].Cells;
            for (int c = 0; c < cells.Count; c++)
            {
                var currentColumnName = cells[c].InnerText == "" ? "link" : cells[c].InnerText;
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
                    dataRow[cells[c].InnerText == "" ? "link" : cells[c].InnerText] = rows[r][c].InnerText;
                }

                dataTable.Rows.Add(dataRow);
            }
        }

        // Export all data to an Excel file
        private static void ExportToExcel(DataTable dataTable, string sheetName, string filePath)
        {
            XLWorkbook workbook = new XLWorkbook();
            workbook.Worksheets.Add(dataTable, sheetName);
            workbook.SaveAs(filePath);
        }
    }
}