namespace Wiki.Models.Wikipedia.Pages.MainPages
{
    using System.Collections.ObjectModel;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class WikiArticlePage : WikiPage
    {
        public WikiArticlePage(string articleName)
            : base(articleName)
        {
            base.Name = articleName;
        }

        #region Web page elements

        /// <summary>
        /// Gets the Create page button.
        /// </summary>
        public HtmlAnchor CreateButton
        {
            get
            {
                return base.manager.ActiveBrowser.Find.ByContent<HtmlAnchor>("Създаване");
            }
        }

        /// <summary>
        /// Gets the page Infobox if exists.
        /// </summary>
        public HtmlTable Infobox
        {
            get
            {
                return base.manager.ActiveBrowser.Find.ByAttributes<HtmlTable>("class=infobox");
            }
        }

        /// <summary>
        /// Gets the element with the all normal page categories.
        /// </summary>
        public HtmlDiv NormalCategories
        {
            get
            {
                return base.manager.ActiveBrowser.Find.ById<HtmlDiv>("mw-normal-catlinks");
            }
        }

        /// <summary>
        /// Gets the element with the all hidden page categories.
        /// </summary>
        public HtmlDiv HiddenCategories
        {
            get
            {
                return base.manager.ActiveBrowser.Find.ById<HtmlDiv>("mw-hidden-catlinks");
            }
        }

        /// <summary>
        /// Gets the list with the all languages on the page.
        /// </summary>
        public ReadOnlyCollection<HtmlListItem> Languages
        {
            get
            {
                return base.manager.ActiveBrowser.Find.AllByAttributes<HtmlListItem>("class=interlanguage-link");
            }
        }

        #endregion

        /// <summary>
        /// The current article page as WikiEditPage. 
        /// </summary>
        /// <returns>Returns an WikiEditPage with the current article name.</returns>
        public WikiEditPage Edit()
        {
            return new WikiEditPage(base.Name);
        }

        /// <summary>
        /// The current article page as WikiDeletePage. 
        /// </summary>
        /// <returns>Returns an WikiDeletePage with the current article name.</returns>
        public WikiDeletePage Delete()
        {
            return new WikiDeletePage(base.Name);
        }
    }
}
