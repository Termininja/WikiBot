namespace Wiki.Core.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ClosedXML.Excel;

    public static class Exporter
    {
        private const string DatabaseUrl = "https://tools.wmflabs.org/templatetiger/tt-table4.php?";
        private const string TemplatesPath = "../../../Wiki.Core/Resources/Templates/";

        private static DataTable dataTable;

        // Export some wiki database to an Excell file
        public static void TaxoboxToExcel(string lang, int start, int linesPerPage, int savePeriod)
        {
            Manager.Current.LaunchNewBrowser(BrowserType.InternetExplorer);
            NavigateTo(lang, start, linesPerPage);
            CreateTable();

            try
            {
                for (int page = 1; page < int.MaxValue; page++)
                {
                    ExtractTable();

                    var realCount = page * linesPerPage + start;
                    if (realCount % savePeriod == 0)
                    {
                        ExportToExcel(TemplatesPath + lang + "/Templates (" + (realCount - savePeriod + 1) + "-" + realCount + ").xlsx");
                        CreateTable();
                    }

                    NavigateTo(lang, realCount, linesPerPage);
                }
            }
            catch (Exception ex)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = "Error: " + ex.Message;
                dataTable.Rows.Add(dataRow);

                ExportToExcel(TemplatesPath + lang + "/Crash.xlsx");
            }
        }

        // Navigate to some Database page
        private static void NavigateTo(string lang, int pageID, int linesPerPage)
        {
            while (true)
            {
                try
                {
                    Manager.Current.ActiveBrowser.NavigateTo(DatabaseUrl +
                        "lang=" + lang.ToLower() +
                        "wiki&template=taxobox&offset=" + pageID +
                        "&limit=" + linesPerPage);
                    break;
                }
                catch (TimeoutException)
                {
                    continue;
                }
            }
        }

        // Create new empty data table
        private static void CreateTable()
        {
            dataTable = new DataTable();
            dataTable.Clear();
        }

        // Take all table's data from the current web page
        private static void ExtractTable()
        {
            HtmlTable table = Manager.Current.ActiveBrowser.Find.ByXPath<HtmlTable>("//html/body/table");
            var cells = table.Rows[0].Cells;
            for (int c = 0; c < cells.Count; c++)
            {
                var currentColumnName = ReadCell(cells, c);
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
                    if (c < rows[r].Cells.Count)
                    {
                        if (dataRow[ReadCell(cells, c)].ToString() == string.Empty)
                        {
                            dataRow[ReadCell(cells, c)] = rows[r][c].InnerText;
                        }
                    }
                }

                dataTable.Rows.Add(dataRow);
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
        private static void ExportToExcel(string filePath)
        {
            XLWorkbook workbook = new XLWorkbook();
            workbook.Worksheets.Add(dataTable, "Taxobox");
            workbook.SaveAs(filePath);
        }
    }
}