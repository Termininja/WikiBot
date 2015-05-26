namespace Wiki.Models.Wikipedia.Pages.MainPages
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.ObjectModel;

    public class WikiHistoryPage : WikiPage
    {
        private const string WikiActionHistoryString = "&action=history";
        private const string WikiLimitString = "&limit=";
        private const int MaxResultsPerPage = 5000;

        private IEnumerable<HtmlListItem> results;

        public WikiHistoryPage(string pageName)
            : base(pageName + WikiActionHistoryString + WikiLimitString + MaxResultsPerPage)
        {
            base.Name = pageName;
        }

        public List<HtmlListItem> GetAllByUsername(string username)
        {
            GetResults();

            return this.results.Where(m => m.Find.ByAttributes<HtmlSpan>("class=history-user").ChildNodes[0].InnerText == username).ToList();
        }

        private void GetResults()
        {
            var unorderedList = base.browser.Find.ById<HtmlUnorderedList>("pagehistory");
            if (unorderedList != null)
            {
                this.results = unorderedList.ChildNodes.Select(m => m.As<HtmlListItem>());
            }
        }
    }
}
