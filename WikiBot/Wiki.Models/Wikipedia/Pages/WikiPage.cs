namespace Wiki.Models.Wikipedia.Pages
{
    using System.IO;
    using System.Net;
    using System.Text.RegularExpressions;
    using System.Web;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;

    public abstract class WikiPage
    {
        protected const string MainUrl = "https://bg.wikipedia.org/w/index.php?title=";
        protected Manager manager;

        public WikiPage(string extraUrl)
        {
            this.Url = MainUrl + extraUrl;
            this.GetManager();
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
                return this.manager.ActiveBrowser.Find.ById("firstHeading").ChildNodes[0].As<HtmlSpan>();
            }
        }

        /// <summary>
        /// Gets the page hystory button if exists.
        /// </summary>
        public HtmlListItem History
        {
            get
            {
                return this.manager.ActiveBrowser.Find.ById<HtmlListItem>("ca-history");
            }
        }

        #endregion

        #region Web page control functions

        /// <summary>
        /// Navigate to some URL. By default navigate to the current URL.
        /// </summary>
        /// <param name="url">The full URL address.</param>
        public void Navigate(string url = null)
        {
            this.manager.ActiveBrowser.NavigateTo(url ?? this.Url);
        }

        /// <summary>
        /// Refresh the DOM tree.
        /// </summary>
        public void RefreshDom()
        {
            this.manager.ActiveBrowser.RefreshDomTree();
        }

        /// <summary>
        /// Set the focus on the page.
        /// </summary>
        public void OnFocus()
        {
            this.manager.ActiveBrowser.Window.SetFocus();
        }

        /// <summary>
        /// Close the page.
        /// </summary>
        public void Close()
        {
            this.manager.ActiveBrowser.Close();
        }

        #endregion

        public OnBeforeUnloadDialog DialogMonitorStart(DialogButton button)
        {
            var dialog = OnBeforeUnloadDialog.CreateOnBeforeUnloadDialog(this.manager.ActiveBrowser, button);
            this.manager.DialogMonitor.AddDialog(dialog);

            return dialog;
        }

        public void DialogMonitorStop(OnBeforeUnloadDialog dialog)
        {
            this.manager.DialogMonitor.AddDialog(dialog);
        }

        private void GetManager()
        {
            this.manager = Manager.Current;
            if (this.manager == null)
            {
                this.manager = new Manager(false);
                this.manager.Start();
                this.manager.LaunchNewBrowser(BrowserType.FireFox);
            }
        }
    }
}
