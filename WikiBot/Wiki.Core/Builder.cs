namespace Wiki.Core
{
    using System.Collections.Generic;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using System.Threading;
    using Models;
    using Models.TaxoBox;

    public class Builder
    {
        private const string LoginWikiUrl = "https://bg.wikipedia.org/w/index.php?title=Специални:Регистриране_или_влизане&returnto=Начална+страница";
        private const string WikipediaUrl = "https://bg.wikipedia.org/wiki/";
        private const string ArticlesPath = "../../../Resources/Articles.xlsx";

        // Generate Wiki articles
        public void GenerateArticles(Log log)
        {
            Manager.Current.LaunchNewBrowser(BrowserType.InternetExplorer);
            Manager.Current.ActiveBrowser.NavigateTo(LoginWikiUrl);
            WikiLogin("Termininja");

            var articles = ReadFromExcel(ArticlesPath);
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
        private void WikiLogin(string username)
        {
            Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("wpName1").Text = username;

            var password = Manager.Current.ActiveBrowser.Find.ById<HtmlInputPassword>("wpPassword1");
            password.Text = "";
            password.MouseClick();

            Thread.Sleep(10000);

            Manager.Current.ActiveBrowser.Find.ById<HtmlInputSubmit>("wpLoginAttempt").Click();
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
    }
}