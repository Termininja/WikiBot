namespace Wiki.Models.Wikipedia.Pages.ResultsPages
{
    using System.Collections.Generic;
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class WikiWhatLinksHerePage : WikiResultsPage
    {
        private const string WikiWhatLinksHereString = "Специални:Какво сочи насам/";
        private const string FilterString = "&hidetrans={0}&hidelinks={1}&hideredirs={2}";

        public WikiWhatLinksHerePage(string pageName, bool hideTrans = false, bool hideLinks = false, bool hideRedirs = false)
            : base(WikiWhatLinksHereString + pageName + string.Format(FilterString, hideTrans ? 1 : 0, hideLinks ? 1 : 0, hideRedirs ? 1 : 0))
        {
            base.Name = pageName;
        }

        protected override IEnumerable<string> Results
        {
            get
            {
                var links = base.manager.ActiveBrowser.Find.ById<HtmlUnorderedList>("mw-whatlinkshere-list");

                if (links != null)
                {
                    return links.ChildNodes.Select(m => m.ChildNodes[0].InnerText);
                }
                else
                {
                    return new List<string>();
                }
            }
        }
    }
}
