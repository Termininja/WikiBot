namespace WikiBot
{
    using System.Data;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.TestTemplates;
    using ClosedXML.Excel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GenerateArticles : BaseTest
    {
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
            ActiveBrowser.NavigateTo("https://tools.wmflabs.org/templatetiger/tt-table4.php?template=taxobox&lang=enwiki&where=&is=&limit=10");

            DataTable dataTable = new DataTable();
            dataTable.Clear();

            int k = 0;
            while (k < 10)
            {
                k++;
                ExtractTable(dataTable);

                // Go to the next page
                var next = Find.ByContent<HtmlAnchor>(">>>");
                if (next != null) next.Click();
                else break;
            }

            ExportToExcel(dataTable, "Taxobox", "TaxoboxTemplates.xlsx");
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