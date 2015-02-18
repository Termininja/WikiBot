namespace Wiki.Models.Wikipedia.Pages.ResultsPages
{
    using System.Collections.Generic;
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class WikiWhatLinksHerePage : WikiResultsPage
    {
        private const string WikiWhatLinksHereString = "Специални:Какво сочи насам/";
        private const string HideLinksAndRedirsString = "&hidelinks=1&hideredirs=1";

        public WikiWhatLinksHerePage(string pageName, bool onlyRealPages = false)
            : base(WikiWhatLinksHereString + pageName + (onlyRealPages ? HideLinksAndRedirsString : null))
        {
            base.Name = pageName;
        }

        protected override IEnumerable<string> Results
        {
            get
            {
                return base.manager.ActiveBrowser.Find.ById<HtmlUnorderedList>("mw-whatlinkshere-list").ChildNodes.Select(m => m.ChildNodes[0].InnerText);
            }
        }
    }
}
