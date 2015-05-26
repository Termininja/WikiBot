namespace Wiki.Models.Wikipedia.Pages.MainPages
{
    using System.Threading;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class WikiMovePage : WikiPage
    {
        private const string WikiMoveString = "Специални:Преместване на страница/";

        public WikiMovePage(string pageName)
            : base(WikiMoveString + pageName)
        {
            base.Name = pageName;
        }

        #region Web page elements

        public HtmlSelect TypeOfPage
        {
            get
            {
                return base.browser.Find.ById<HtmlSelect>("wpNewTitleNs");
            }
        }

        public HtmlInputText NewTitle
        {
            get
            {
                return base.browser.Find.ById<HtmlInputText>("wpNewTitleMain");
            }
        }

        public HtmlInputText Reason
        {
            get
            {
                return base.browser.Find.ById<HtmlInputText>("wpReason");
            }
        }

        private HtmlInputCheckBox Watch
        {
            get
            {
                return base.browser.Find.ById<HtmlInputCheckBox>("watch");
            }
        }

        private HtmlInputSubmit MoveButton
        {
            get
            {
                return base.browser.Find.ByName<HtmlInputSubmit>("wpMove");
            }
        }

        #endregion

        public override void Navigate(string url = null)
        {
            base.Navigate(url);

            while (base.browser.Find.ByName<HtmlInputSubmit>("wpMove") == null)
            {
                Thread.Sleep(RefreshDomTreeInterval);
                base.RefreshDom();
            }
        }

        public void Move()
        {
            if (this.MoveButton != null)
            {
                this.MoveButton.Click();
            }
        }

        public void WatchIt(bool watch)
        {
            if (this.Watch != null)
            {
                this.Watch.Check(watch, true);
            }
        }
    }
}