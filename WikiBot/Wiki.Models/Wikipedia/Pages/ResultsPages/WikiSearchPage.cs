namespace Wiki.Models.Wikipedia.Pages.ResultsPages
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class WikiSearchPage : WikiResultsPage
    {
        private const string WikiSearchString = "Специални:Търсене&offset=0&search=";
        private const string ShowPortalsString = "&ns0=1";

        public WikiSearchPage(string searchWord, bool portal = true)
            : base(WikiSearchString + searchWord + (portal ? null : ShowPortalsString))
        {
            base.Name = searchWord;
        }

        protected override IEnumerable<string> Results
        {
            get
            {
                var divs = base.manager.ActiveBrowser.Find.AllByAttributes<HtmlDiv>("class=mw-search-result-heading");

                return divs.Select(m => HttpUtility.HtmlDecode((m.Find.AllByTagName<HtmlAnchor>("a"))[0].Title));
            }
        }
    }
}
