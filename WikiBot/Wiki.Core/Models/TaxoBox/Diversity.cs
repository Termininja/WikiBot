namespace Wiki.Core.Models.TaxoBox
{
    using System.Text;

    public class Diversity
    {
        private string diversityName;

        private string diversityLink;

        public Diversity(string name, string link)
        {
            this.diversityName = name;
            this.diversityLink = link;
        }

        public override string ToString()
        {
            StringBuilder diversity = new StringBuilder();

            if (this.diversityName != null) diversity.AppendLine("| diversity = " + this.diversityName);
            if (this.diversityLink != null) diversity.AppendLine("| diversity_link = " + this.diversityLink);

            return diversity.ToString();
        }
    }
}
