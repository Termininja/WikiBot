namespace Wiki.Models.Wikipedia.Pages.MainPages
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.ObjectModel;

    public class WikiEditPage : WikiPage
    {
        private const string WikiActionEditString = "&action=edit";
        private const int RefreshDomTreeInterval = 10;

        private HtmlTextArea textarea;
        private HtmlInputText summary;

        public WikiEditPage(string pageName)
            : base(pageName + WikiActionEditString)
        {
            base.Name = pageName;
        }

        #region Web page elements

        /// <summary>
        /// Gets the all suggestions from the Advisor Gadget.
        /// </summary>
        public ReadOnlyCollection<Element> AllAdvisorSuggestions
        {
            get
            {
                return base.manager.ActiveBrowser.Find.ById<HtmlDiv>("mw-content-text").ChildNodes[2].ChildNodes;
            }
        }

        /// <summary>
        /// Gets the last suggestion from the Advisor Gadget.
        /// </summary>
        public HtmlAnchor LastAdvisorSuggestion
        {
            get
            {
                return this.AllAdvisorSuggestions.Last().As<HtmlAnchor>();
            }
        }

        /// <summary>
        /// Gets the minor edits check box page button.
        /// </summary>
        public HtmlInputCheckBox MinorEdit
        {
            get
            {
                return base.manager.ActiveBrowser.Find.ById<HtmlInputCheckBox>("wpMinoredit");
            }
        }

        /// <summary>
        /// Gets the watch it check box page button.
        /// </summary>
        public HtmlInputCheckBox WatchIt
        {
            get
            {
                return base.manager.ActiveBrowser.Find.ById<HtmlInputCheckBox>("wpWatchthis");
            }
        }

        /// <summary>
        /// Gets the page edit textarea.
        /// </summary>
        public string Textarea
        {
            get
            {
                while (base.manager.ActiveBrowser.Find.ById<HtmlTextArea>("wpTextbox1") == null)
                {
                    Thread.Sleep(RefreshDomTreeInterval);
                    base.RefreshDom();
                }

                this.textarea = base.manager.ActiveBrowser.Find.ById<HtmlTextArea>("wpTextbox1");

                return this.textarea.Text;
            }
            set
            {
                this.textarea.Text = value;
            }
        }

        /// <summary>
        /// Gets the summary field.
        /// </summary>
        public string Summary
        {
            get
            {
                this.summary = base.manager.ActiveBrowser.Find.ById<HtmlInputText>("wpSummary");

                return this.summary.Text;
            }
            set
            {
                var oldSummary = this.Summary;
                this.summary.Text = oldSummary + value;
            }
        }

        #endregion

        /// <summary>
        /// Save the current page changes.
        /// </summary>
        public void Save()
        {
            base.manager.ActiveBrowser.Find.ById<HtmlInputSubmit>("wpSave").Click();

            while (base.manager.ActiveBrowser.Find.ById<HtmlInputSubmit>("wpSave") != null)
            {
                Thread.Sleep(RefreshDomTreeInterval);
                base.RefreshDom();
            }
        }

        /// <summary>
        /// Preview the current page edits.
        /// </summary>
        public void Preview()
        {
            base.manager.ActiveBrowser.Find.ById<HtmlInputSubmit>("wpPreview").Click();
        }

        /// <summary>
        /// Check the differences.
        /// </summary>
        public void Differences()
        {
            base.manager.ActiveBrowser.Find.ById<HtmlInputSubmit>("wpDiff").Click();
        }

        public void Replace(string oldString, string newString)
        {
            this.Textarea = this.Textarea.Replace(oldString, newString);
        }

        public HtmlAnchor GetAdvisorSuggestion(int suggestion)
        {
            return (this.AllAdvisorSuggestions[suggestion + 1].ChildNodes[0]).As<HtmlAnchor>();
        }

        /// <summary>
        /// Adds the Advisor Gadget summary for the suggestions which are done.
        /// </summary>
        public void AddAdvisorSummary()
        {
            var advisorSummary = base.manager.ActiveBrowser.Find.ByContent<HtmlAnchor>("Добави към резюмето");
            if (advisorSummary != null)
            {
                advisorSummary.Click();
            }
        }
    }
}
