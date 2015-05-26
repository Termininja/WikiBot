namespace Wiki.Models.Wikipedia.Pages.MainPages
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class WikiCategoryPage : WikiArticlePage
    {
        private const string WikiCategoryString = "Категория:";

        public WikiCategoryPage(string categoryName)
            : base(WikiCategoryString + categoryName)
        {
            base.Name = categoryName;
        }

        #region Web page elements

        /// <summary>
        /// Gets an collection with the all sub category pages in the current category page.
        /// </summary>
        public ReadOnlyCollection<HtmlAnchor> SubCategories
        {
            get
            {
                var subcategories = base.browser.Find.ById<HtmlDiv>("mw-subcategories");
                if (subcategories != null)
                {
                    return subcategories.Find.AllByTagName<HtmlAnchor>("a");
                }

                return new ReadOnlyCollection<HtmlAnchor>(new List<HtmlAnchor>());
            }
        }

        /// <summary>
        /// Gets an collection with the all pages in the current category page.
        /// </summary>
        public ReadOnlyCollection<HtmlAnchor> Pages
        {
            get
            {
                var pages = base.browser.Find.ById<HtmlDiv>("mw-pages");
                if (pages != null)
                {
                    var pageList = pages.Find.ByAttributes<HtmlDiv>("class=mw-content-ltr");

                    return pageList.Find.AllByTagName<HtmlAnchor>("a");
                }

                return new ReadOnlyCollection<HtmlAnchor>(new List<HtmlAnchor>());
            }
        }

        /// <summary>
        /// Gets the button for the next 200 pages in this category page.
        /// </summary>
        public HtmlAnchor NextButton
        {
            get
            {
                return base.browser.Find.ByContent<HtmlAnchor>("следващи 200");
            }
        }

        #endregion
    }
}
