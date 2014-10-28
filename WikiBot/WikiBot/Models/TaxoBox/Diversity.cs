namespace WikiBot.Models.TaxoBox
{
    using System.Text;

    public class Diversity
    {
        public string DiversityName { get; set; }

        public string DiversityLink { get; set; }

        public Diversity(string name, string link)
        {
            this.DiversityName = name;
            this.DiversityLink = link;
        }

        public override string ToString()
        {
            StringBuilder diversity = new StringBuilder();

            //TODO

            return diversity.ToString();
        }
    }
}
