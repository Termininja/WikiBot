namespace WikiBot
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.TestTemplates;
    using ClosedXML.Excel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;
    using Models.TaxoBox;

    [TestClass]
    public class WikiArticles : BaseTest
    {
        private const string DatabaseUrl = "https://tools.wmflabs.org/templatetiger/tt-table4.php?";
        private const string LoginWikiUrl = "https://bg.wikipedia.org/w/index.php?title=Специални:Регистриране_или_влизане&returnto=Начална+страница";
        private const string WikipediaUrl = "https://bg.wikipedia.org/wiki/";
        private const string TemplatesPath = "../../../Resources/Templates/";
        private const string ArticlesPath = "../../../Resources/Articles.xlsx";
        private const string Template = "Taxobox";

        private const int Start = 130000;
        private const int Lines = 500;
        private const int Period = 10000;

        public TestContext TestContext { get; set; }
        public DataTable DataTable { get; set; }

        #region Initialize & Cleanup

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

        #endregion

        #region Export Wiki Database to Excell

        [TestMethod]
        public void ExportEnWiki()
        {
            this.ExportTaxoboxTemplateToExcel("En");
        }

        [TestMethod]
        public void ExportSvWiki()
        {
            this.ExportTaxoboxTemplateToExcel("Sv");
        }

        // Export some wiki database to an Excell file
        public void ExportTaxoboxTemplateToExcel(string lang)
        {
            Manager.LaunchNewBrowser(BrowserType.InternetExplorer);
            ActiveBrowser.NavigateTo(DatabaseUrl + "lang=" + lang.ToLower() + "wiki&template=" + Template + "&offset=" + Start + "&limit=" + Lines);
            this.CreateTable();

            try
            {
                for (int count = Start + 1; count < int.MaxValue; count++)
                {
                    this.ExtractTable();

                    if ((((count - Start) * Lines) + Start) % Period == 0)
                    {
                        int realCount = (count - Start) * Lines + Start;
                        this.ExportToExcel(TemplatesPath + lang + "/Templates (" + (realCount - Period + 1) + "-" + realCount + ").xlsx");
                        this.CreateTable();
                    }

                    // Go to the next page
                    try
                    {
                        var next = Find.ByContent<HtmlAnchor>(">>>");
                        if (next != null) next.Click();
                        else throw new Exception(); //break;
                    }
                    catch (Exception)
                    {
                        int nextPage = Start + (count - Start) * Lines;
                        ActiveBrowser.NavigateTo(LoginWikiUrl + "lang=" + lang.ToLower() + "wiki&template=" + Template + "&offset=" + nextPage + "&limit=" + Lines);
                    }
                }
            }
            finally
            {
                this.ExportToExcel(TemplatesPath + lang + "/Crash.xlsx");
            }
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
            HtmlTable table = Find.ByXPath<HtmlTable>("//html/body/table");
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

        #endregion

        #region Generate Wiki Articles

        [TestMethod]
        public void GenerateArticles()
        {
            Manager.LaunchNewBrowser(BrowserType.InternetExplorer);
            ActiveBrowser.NavigateTo(LoginWikiUrl);
            WikiLogin("Termininja");

            var articles = ReadFromExcel(ArticlesPath);
            foreach (var article in articles)
            {
                ActiveBrowser.NavigateTo(WikipediaUrl + article.Name);
                var create = Find.ByContent<HtmlAnchor>("Създаване");
                if (create != null)
                {
                    // Create article
                    create.Click();

                    Find.ById<HtmlTextArea>("wpTextbox1").Text = article.ToString();
                    //Find.ById<HtmlInputText>("wpSummary").Text = "This article was created automatically";

                    Find.ById<HtmlInputSubmit>("wpPreview").Click();
                    //Find.ById<HtmlInputSubmit>("wpSave").Click();
                }
                else
                {
                    Log.WriteLine("An article with name \"" + article.Name + "\" already exists!");
                }
            }
        }

        // Login in Wikipedia
        private void WikiLogin(string username)
        {
            Find.ById<HtmlInputText>("wpName1").Text = username;

            var password = Find.ById<HtmlInputPassword>("wpPassword1");
            password.Text = "";
            password.MouseClick();

            Thread.Sleep(10000);

            Find.ById<HtmlInputSubmit>("wpLoginAttempt").Click();
        }

        // Read from Excel file - TODO!
        private static List<Article> ReadFromExcel(string filePath)
        {
            var articles = new List<Article>();

            // Example
            {
                var taxobox = new Taxobox();
                taxobox.AddAuthority(new Authority(BioType.Binomial, "authority", "Pesho"));
                taxobox.Diversity = new Diversity("diversity name", "diversity link");
                taxobox.Image = new Image("Eunectes murinus.jpg", "some image caption");

                var taxonomy = new Taxonomy();
                taxonomy.Regnum = new Taxon("regnumEn", "regnumBg");
                taxonomy.Classis = new Taxon("classEn", "classBg");
                taxonomy.Ordo = new Taxon("ordoEn", "ordoBg");
                taxonomy.Species = new Taxon("speciesEn", "speciesBg");
                taxobox.Taxonomy = taxonomy;

                taxobox.Synonyms = "* synonym1 {{br}} *synonym2";
                taxobox.Map = new Map("map.jpg", "map caption");

                var article = new Article("Big article", taxobox, StubType.Animal);
                article.AddCategory("some category");
                article.AddCategory("some category 2");

                articles.Add(article);
            }

            return articles;
        }
        
        #endregion
    }
}