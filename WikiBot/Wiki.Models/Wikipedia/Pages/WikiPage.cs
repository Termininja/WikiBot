namespace Wiki.Models.Wikipedia.Pages
{
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;

    public abstract class WikiPage
    {
        protected const string MainUrl = "https://bg.wikipedia.org/w/index.php?title=";
        protected const int RefreshDomTreeInterval = 10;
        protected Browser browser;

        public WikiPage(string extraUrl)
        {
            this.Url = MainUrl + extraUrl;
            this.browser = this.GetBrowser();
        }

        public string Url { get; set; }

        public string Name { get; set; }

        public string WebContent
        {
            get
            {
                using (var webResponse = (HttpWebResponse)WebRequest.Create(this.Url).GetResponse())
                {
                    using (var reader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }

        #region Web page elements

        /// <summary>
        /// Gets the page title if exists.
        /// </summary>
        public HtmlSpan Title
        {
            get
            {
                return this.browser.Find.ById("firstHeading").ChildNodes[0].As<HtmlSpan>();
            }
        }

        /// <summary>
        /// Gets the page hystory button if exists.
        /// </summary>
        public HtmlListItem History
        {
            get
            {
                return this.browser.Find.ById<HtmlListItem>("ca-history");
            }
        }

        #endregion

        #region Web page control functions

        /// <summary>
        /// Navigate to some URL. By default navigate to the current URL.
        /// </summary>
        /// <param name="url">The full URL address.</param>
        public virtual void Navigate(string url = null)
        {
            this.browser.NavigateTo(url ?? this.Url);
            Thread.Sleep(100);
            this.RefreshDom();
        }

        /// <summary>
        /// Refresh the DOM tree for specific browser.
        /// </summary>
        public void RefreshDom()
        {
            this.browser.RefreshDomTree();
        }

        /// <summary>
        /// Set the focus on the page.
        /// </summary>
        public void OnFocus()
        {
            this.browser.Window.SetFocus();
        }

        /// <summary>
        /// Close the page.
        /// </summary>
        public void Close()
        {
            this.browser.Close();
        }

        #endregion

        public OnBeforeUnloadDialog DialogMonitorStart(DialogButton button)
        {
            var dialog = OnBeforeUnloadDialog.CreateOnBeforeUnloadDialog(this.browser, button);
            Manager.Current.DialogMonitor.AddDialog(dialog);

            return dialog;
        }

        public void DialogMonitorStop(OnBeforeUnloadDialog dialog)
        {
            Manager.Current.DialogMonitor.AddDialog(dialog);
        }

        private Browser GetBrowser()
        {
            var manager = Manager.Current;
            if (manager == null)
            {
                manager = new Manager(false);
                manager.Start();
                manager.LaunchNewBrowser(BrowserType.FireFox);
                Thread.Sleep(1000);
            }

            return manager.Browsers.Last();
        }
    }
}
