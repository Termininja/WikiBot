namespace Wiki.Models.Wikipedia.Pages.MainPages
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class WikiDeletePage : WikiPage
    {
        private const string WikiActionDeleteString = "&action=delete";

        public WikiDeletePage(string pageName)
            : base(pageName + WikiActionDeleteString)
        {
            base.Name = pageName;
        }

        #region Web page elements

        public HtmlSelect Reason
        {
            get
            {
                return base.browser.Find.ById<HtmlSelect>("wpDeleteReasonList");
            }
        }

        public HtmlInputText AuxiliaryReason
        {
            get
            {
                return base.browser.Find.ById<HtmlInputText>("wpReason");
            }
        }

        public HtmlInputCheckBox WatchIt
        {
            get
            {
                return base.browser.Find.ById<HtmlInputCheckBox>("wpWatch");
            }
        }

        public HtmlInputSubmit Delete
        {
            get
            {
                return base.browser.Find.ById<HtmlInputSubmit>("wpConfirmB");
            }
        }

        #endregion
    }
}