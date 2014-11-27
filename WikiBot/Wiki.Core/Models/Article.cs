namespace Wiki.Core.Models
{
    using System.Collections.Generic;
    using System.Text;

    using TaxoBox;
    using Wiki.Core.Data;

    public class Article
    {
        private List<string> categories;

        private Stub type;

        public Article(string articleName, Taxobox taxobox, Stub stubType)
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

        private string GetStub(Stub stubType)
        {
            switch (stubType)
            {
                case Stub.Animal: return "животно";
                case Stub.Fungi: return "гъба";
                case Stub.Plant: return "растение";
                case Stub.Biology: return "биология";
                default: return null;
            }
        }
    }
}