namespace Wiki.Core
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ClosedXML.Excel;

    public class Exporter
    {
        private const string DatabaseUrl = "https://tools.wmflabs.org/templatetiger/tt-table4.php?";
        private const string TemplatesPath = "../../../Resources/Templates/";
        private const string Template = "Taxobox";

        public DataTable DataTable { get; set; }

        // Export some wiki database to an Excell file
        public void TaxoboxToExcel(string lang, int start, int linesPerPage, int savePeriod)
        {
            Manager.Current.LaunchNewBrowser(BrowserType.InternetExplorer);
            this.NavigateToNextPage(lang, start, linesPerPage);
            this.CreateTable();

            try
            {
                for (int count = start + 1; count < int.MaxValue; count++)
                {
                    this.ExtractTable();

                    if ((((count - start) * linesPerPage) + start) % savePeriod == 0)
                    {
                        int realCount = (count - start) * linesPerPage + start;
                        this.ExportToExcel(TemplatesPath + lang + "/Templates (" + (realCount - savePeriod + 1) + "-" + realCount + ").xlsx");
                        this.CreateTable();
                    }

                    NavigateToNextPage(lang, start + (count - start) * linesPerPage, linesPerPage);
                }
            }
            catch (Exception ex)
            {
                DataRow dataRow = this.DataTable.NewRow();
                dataRow[0] = ex;
                this.DataTable.Rows.Add(dataRow);

                this.ExportToExcel(TemplatesPath + lang + "/Crash.xlsx");
            }
        }

        // Navigate to the next Database page
        private void NavigateToNextPage(string lang, int pageID, int linesPerPage)
        {
            Manager.Current.ActiveBrowser.NavigateTo(DatabaseUrl + "lang=" + lang.ToLower() + "wiki&template=" + Template + "&offset=" + pageID + "&limit=" + linesPerPage);
        }

        // Create new empty data table
        private void CreateTable()
        {
            this.DataTable = new DataTable();
            this.DataTable.Clear();
        }

        // Take all table's data from the current web page
        private void ExtractTable()
        {
            HtmlTable table = Manager.Current.ActiveBrowser.Find.ByXPath<HtmlTable>("//html/body/table");
            var cells = table.Rows[0].Cells;
            for (int c = 0; c < cells.Count; c++)
            {
                var currentColumnName = ReadCell(cells, c);
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
                    if (c < rows[r].Cells.Count)
                    {
                        if (dataRow[ReadCell(cells, c)].ToString() == string.Empty)
                        {
                            dataRow[ReadCell(cells, c)] = rows[r][c].InnerText;
                        }
                    }
                }

                this.DataTable.Rows.Add(dataRow);
            }
        }

        // Read the value from the current cell
        private static string ReadCell(List<HtmlTableCell> cells, int currentCell)
        {
            string cellValue = string.Empty;

            switch (cells[currentCell].InnerText)
            {
                case "": cellValue = "link"; break;
                case "0": cellValue = "zero"; break;
                case "1": cellValue = "one"; break;
                case "2": cellValue = "two"; break;
                case "3": cellValue = "three"; break;
                case "4": cellValue = "four"; break;
                case "5": cellValue = "five"; break;
                default: cellValue = cells[currentCell].InnerText; break;
            }

            return cellValue;
        }

        // Export all data to an Excel file
        private void ExportToExcel(string filePath)
        {
            XLWorkbook workbook = new XLWorkbook();
            workbook.Worksheets.Add(this.DataTable, Template);
            workbook.SaveAs(filePath);
        }
    }
}