namespace Wiki.Core.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;
    using System.Linq;
    using System.Threading;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using Models;
    using Models.TaxoBox;
    using Wiki.Core.Data;

    public static class Builder
    {
        private const string LoginWikiUrl = "https://bg.wikipedia.org/w/index.php?title=Специални:Регистриране_или_влизане&returnto=Начална+страница";
        private const string WikipediaUrl = "https://bg.wikipedia.org/wiki/";
        private const string ArticlesPath = "../../../Wiki.Core/Resources/Articles.xlsx";

        // Generate Wiki articles
        public static void GenerateArticles(Log log)
        {
            Manager.Current.LaunchNewBrowser(BrowserType.InternetExplorer);
            Manager.Current.ActiveBrowser.NavigateTo(LoginWikiUrl);
            WikiLogin();

            var articles = ReadFromExcel(Path.GetFullPath(ArticlesPath));
            foreach (var article in articles)
            {
                Manager.Current.ActiveBrowser.NavigateTo(WikipediaUrl + article.Name);
                var create = Manager.Current.ActiveBrowser.Find.ByContent<HtmlAnchor>("Създаване");
                if (create != null)
                {
                    // Create article
                    create.Click();

                    Manager.Current.ActiveBrowser.Find.ById<HtmlTextArea>("wpTextbox1").Text = article.ToString();
                    //Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("wpSummary").Text = "This article was created automatically";

                    Manager.Current.ActiveBrowser.Find.ById<HtmlInputSubmit>("wpPreview").Click();
                    //Manager.Current.ActiveBrowser.Find.ById<HtmlInputSubmit>("wpSave").Click();
                }
                else
                {
                    log.WriteLine("An article with name \"" + article.Name + "\" already exists!");
                }
            }
        }

        // Login in Wikipedia
        private static void WikiLogin()
        {
            var password = Manager.Current.ActiveBrowser.Find.ById<HtmlInputPassword>("wpPassword1");
            password.MouseClick();

            while (Manager.Current.ActiveBrowser.Find.ById<HtmlInputSubmit>("wpLoginAttempt") != null)
            {
                Manager.Current.ActiveBrowser.RefreshDomTree();
                Thread.Sleep(1000);
            }
        }

        // Reads the data from some Excel file
        private static List<Article> ReadFromExcel(string filePath)
        {
            var dataTable = new DataTable();
            var connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Excel 12.0; HDR=YES; Data Source = " + filePath);
            using (connection)
            {
                connection.Open();
                var dataAdapter = new OleDbDataAdapter(@"SELECT * FROM [Taxobox$]", connection);
                dataAdapter.Fill(dataTable);
            }

            var articles = new List<Article>();
            foreach (DataRow row in dataTable.Rows)
            {
                if (row.ItemArray.Any(i => i != DBNull.Value))
                {
                    var taxobox = new Taxobox();
                    //taxobox.AddAuthority(new Authority(BioType.Binomial, row["name"].ToString(), row["authority"].ToString()));
                    //taxobox.Diversity = new Diversity("diversity name", "diversity link");
                    //taxobox.Image = new Image(row["image"].ToString(), row["image_caption"].ToString());

                    var taxonomy = new Taxonomy();
                    //taxonomy.GetText();

                    foreach (var rank in taxonomy.Ranks)
                    {
                        try
                        {
                            var cell = row[rank].ToString();
                            if (!string.IsNullOrEmpty(cell))
                            {
                                taxonomy.AddTaxon(rank, cell, null);
                            }
                        }
                        catch (ArgumentException) { }
                    }

                    taxobox.Taxonomy = taxonomy;

                    taxobox.Synonyms = "* synonym1 {{br}} *synonym2";
                    taxobox.Map = new Map("map.jpg", "map caption");

                    var article = new Article("Big article", taxobox, Stub.Animal);
                    article.AddCategory("some category");
                    article.AddCategory("some category 2");

                    articles.Add(article);
                }
            }

            return articles;
        }
    }
}