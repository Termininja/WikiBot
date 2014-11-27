namespace Wiki.Core.Factory
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;

    using ClosedXML.Excel;

    public class Unifier
    {
        private const string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Excel 12.0; HDR=YES; Data Source = ";
        private const string FilesDirectory = "../../../Wiki.Core/Resources/Templates/";

        private static DataTable inputDataTable;
        private static DataTable outputDataTable;

        private static List<string> columnNames = new List<string>();

        // Get all column names from a group of Excel files
        public static void GetColumnNames(string lang)
        {
            try
            {
                inputDataTable = new DataTable();
                for (int i = 0; i < int.MaxValue; i++)
                {
                    var connection = new OleDbConnection(ConnectionString + FilesDirectory + lang + "/Templates " + i + ".xlsx");
                    using (connection)
                    {
                        connection.Open();
                        var dataAdapter = new OleDbDataAdapter(@"SELECT * FROM [Taxobox$]", connection);
                        dataAdapter.Fill(inputDataTable);
                    }

                    foreach (DataColumn column in inputDataTable.Columns)
                    {
                        var name = column.ColumnName;
                        if (!columnNames.Contains(name)) columnNames.Add(name);
                    }

                    inputDataTable = new DataTable();
                    inputDataTable.Clear();
                }
            }
            catch (OleDbException)
            {
                ExportColumnNames(lang);
            }
        }

        // Get all column names from a group of Excel files
        public static void CreateUnitedTable(string lang)
        {
            inputDataTable = new DataTable();
            ReadColumnNames(lang);
            CreateTableColumns();

            int counter = 0;

            try
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    var connection = new OleDbConnection(ConnectionString + FilesDirectory + lang + "/Templates " + i + ".xlsx");
                    using (connection)
                    {
                        connection.Open();
                        var dataAdapter = new OleDbDataAdapter(@"SELECT * FROM [Taxobox$]", connection);
                        dataAdapter.Fill(inputDataTable);
                    }

                    foreach (DataRow row in inputDataTable.Rows)
                    {
                        DataRow dataRow = outputDataTable.NewRow();
                        foreach (DataColumn column in inputDataTable.Columns)
                        {
                            dataRow[column] = row[column.ColumnName].ToString();
                        }

                        outputDataTable.Rows.Add(dataRow);
                    }

                    if (outputDataTable.Rows.Count >= 50000)
                    {
                        ExportToExcel(lang, counter);
                        counter++;
                    }
                }
            }
            catch (OleDbException)
            {
                ExportToExcel(lang, counter);
            }
        }

        private static void ExportColumnNames(string lang)
        {
            StreamWriter writer = new StreamWriter(FilesDirectory + "Columns" + lang + ".txt", false);
            using (writer)
            {
                foreach (var name in columnNames)
                {
                    writer.WriteLine(name);
                }
            }
        }

        private static void ReadColumnNames(string lang)
        {
            StreamReader reader = new StreamReader(FilesDirectory + "Columns" + lang + ".txt");
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    columnNames.Add(line);
                    line = reader.ReadLine();
                }
            }
        }

        private static void CreateTableColumns()
        {
            outputDataTable = new DataTable();
            foreach (var name in columnNames)
            {
                if (!outputDataTable.Columns.Contains(name))
                {
                    outputDataTable.Columns.Add(name);
                }
            }
        }

        private static void ExportToExcel(string lang, int counter)
        {
            XLWorkbook workbook = new XLWorkbook();
            workbook.Worksheets.Add(outputDataTable, "Taxobox");
            workbook.SaveAs(FilesDirectory + lang + "/Unified " + counter + ".xlsx");

            // Reset all data tables
            inputDataTable = new DataTable();
            inputDataTable.Clear();

            outputDataTable = new DataTable();
            outputDataTable.Clear();
            CreateTableColumns();
        }
    }
}