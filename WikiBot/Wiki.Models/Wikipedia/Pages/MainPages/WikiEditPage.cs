namespace Wiki.Models.Wikipedia.Pages.MainPages
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.ObjectModel;

    public class WikiEditPage : WikiPage
    {
        private const string WikiActionEditString = "&action=edit";
        private HtmlTextArea textarea;
        private HtmlInputText summary;

        public List<string> SuggestionWords = new List<string>() { 
            "интервали", "дв. интервал", "нов ред", "год.→г.", "число+г.", "А|АБ", "А|А", "заглавие", //"запетая"
        };      //TODO: Not work for "нов ред" or ...

        public WikiEditPage(string pageName)
            : base(pageName + WikiActionEditString)
        {
            base.Name = pageName;
        }

        #region Web page elements

        /// <summary>
        /// Gets the all suggestions by the Advisor Gadget.
        /// </summary>
        private ReadOnlyCollection<Element> AdvisorSuggestions
        {
            get
            {
                return base.browser.Find.ById<HtmlDiv>("mw-content-text").ChildNodes[2].ChildNodes;
            }
        }

        /// <summary>
        /// Gets the page edit textarea.
        /// </summary>
        public string Textarea
        {
            get
            {
                this.textarea = base.browser.Find.ById<HtmlTextArea>("wpTextbox1");

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
                this.summary = base.browser.Find.ById<HtmlInputText>("wpSummary");

                return this.summary.Text;
            }
            set
            {
                var oldSummary = this.Summary;
                this.summary.Text = oldSummary + value;
            }
        }

        #endregion

        public override void Navigate(string url = null)
        {
            base.Navigate(url);

            while (base.browser.Find.ById<HtmlTextArea>("wpTextbox1") == null)
            {
                Thread.Sleep(RefreshDomTreeInterval);
                base.RefreshDom();
            }
        }

        /// <summary>
        /// Save the current page changes.
        /// </summary>
        public void Save()
        {
            base.browser.Find.ById<HtmlInputSubmit>("wpSave").Click();

            while (base.browser.Find.ById<HtmlInputSubmit>("wpSave") != null)
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
            base.browser.Find.ById<HtmlInputSubmit>("wpPreview").Click();
        }

        /// <summary>
        /// Check the differences.
        /// </summary>
        public void Differences()
        {
            base.browser.Find.ById<HtmlInputSubmit>("wpDiff").Click();
        }

        /// <summary>
        /// Watch the current page.
        /// </summary>
        /// <param name="isWatched">By default is 'true'.</param>
        public void WatchIt(bool isWatched = true)
        {
            var checkBox = base.browser.Find.ById<HtmlInputCheckBox>("wpWatchthis");
            if (checkBox != null)
            {
                checkBox.Check(isWatched, true);
            }
        }

        /// <summary>
        /// Marks the current edit as minor.
        /// </summary>
        /// <param name="isMinor">By default is 'true'.</param>
        public void MinorEdit(bool isMinor = true)
        {
            var checkBox = base.browser.Find.ById<HtmlInputCheckBox>("wpMinoredit");
            if (checkBox != null)
            {
                checkBox.Check(isMinor, true);
            }
        }

        /// <summary>
        /// Checks for Advisor Gadget suggestions and adds edit summary.
        /// </summary>
        public void AdvisorCheck()
        {
            this.RefreshDom();
            var suggestions = this.AdvisorSuggestions;
            if (suggestions.Last().InnerText == "...")
            {
                suggestions.Last().As<HtmlAnchor>().Click();
            }

            for (int s = 1; s < suggestions.Count; s += 2)
            {
                if (this.SuggestionWords.Contains(suggestions[s].InnerText))
                {
                    var addSuggestions = (this.AdvisorSuggestions[s + 1].ChildNodes[0]).As<HtmlAnchor>();
                    addSuggestions.Click();
                    this.RefreshDom();
                    suggestions = this.AdvisorSuggestions;
                    s = -1;
                }
            }

            this.RefreshDom();
            var advisorSummary = base.browser.Find.ByContent<HtmlAnchor>("Добави към резюмето");
            if (advisorSummary != null)
            {
                advisorSummary.Click();
            }
        }
    }
}
