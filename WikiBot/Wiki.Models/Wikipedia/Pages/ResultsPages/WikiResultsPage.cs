namespace Wiki.Models.Wikipedia.Pages.ResultsPages
{
    using System.Collections.Generic;
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    public abstract class WikiResultsPage : WikiPage
    {
        private const string WikiLimitString = "&limit=";
        private const int MaxResultsPerPage = 5000;

        public WikiResultsPage(string pageName)
            : base(pageName + WikiLimitString + MaxResultsPerPage) { }

        protected abstract IEnumerable<string> Results { get; }

        public List<string> GetResults()
        {
            var results = this.Results;
            while (true)
            {
                // "по-стари" for WikiHistoryPage
                var nextButton = base.browser.Find.ByContent<HtmlAnchor>("следващи " + MaxResultsPerPage);
                if (nextButton != null) nextButton.Click();
                else break;

                base.RefreshDom();
                results = results.Concat(this.Results);
            }

            return results.ToList();
        }
    }
}
