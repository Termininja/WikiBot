namespace Wiki.Models.Wikipedia.Pages.ResultsPages
{
    using System.Collections.Generic;
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class WikiSearchPage : WikiResultsPage
    {
        private const string WikiSearchString = "Специални:Търсене&offset=0&search=";

        public WikiSearchPage(string searchWord)
            : base(WikiSearchString + searchWord)
        {
            base.Name = searchWord;
        }

        protected override IEnumerable<string> Results
        {
            get
            {
                return base.manager.ActiveBrowser.Find.AllByAttributes<HtmlDiv>("class=mw-search-result-heading").Select(m => m.ChildNodes[0].InnerText);
            }
        }
    }
}
