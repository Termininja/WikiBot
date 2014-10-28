namespace WikiBot.Models
{
    using System.Collections.Generic;
    using System.Text;

    using TaxoBox;

    public class Article
    {
        private List<string> categories;
        private StubType type;

        public Article(string articleName, Taxobox taxobox, StubType stubType)
        {
            this.Name = articleName;
            this.Taxobox = taxobox;
            this.type = stubType;
            this.categories = new List<string>();
        }

        public string Name { get; set; }
        public Taxobox Taxobox { get; set; }

        public void AddCategory(string category)
        {
            this.categories.Add(category);
        }

        public override string ToString()
        {
            StringBuilder article = new StringBuilder();

            article.AppendLine(this.Taxobox.ToString());
            if (this.Taxobox.Taxonomy != null)
            {
                article.AppendLine(this.Taxobox.Taxonomy.GetText(this.Name));
            }

            article.AppendLine("== Източници ==");
            article.AppendLine("<references/>");
            article.AppendLine();
            article.AppendLine("{{" + GetStub(this.type) + "-мъниче}}");

            if (this.categories.Count > 0)
            {
                article.AppendLine();

                foreach (var category in this.categories)
                {
                    article.AppendLine("[[Категория:" + category + "]]");
                }
            }

            return article.ToString();
        }

        private string GetStub(StubType stubType)
        {
            switch (stubType)
            {
                case StubType.Animal: return "животно";
                case StubType.Fungi: return "гъба";
                case StubType.Plant: return "растение";
                case StubType.Biology: return "биология";
                default: return null;
            }
        }
    }
}