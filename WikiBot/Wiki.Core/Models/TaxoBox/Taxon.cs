namespace Wiki.Core.Models.TaxoBox
{
    using System.Text;

    public class Taxon
    {
        public Taxon(string name, string name_bg)
        {
            this.Name = name;
            this.Name_bg = name_bg;
        }

        public string Name { get; set; }

        public string Name_bg { get; set; }

        public string Value { get; set; }

        public string Value_bg { get; set; }

        public override string ToString()
        {
            StringBuilder taxon = new StringBuilder();

            taxon.AppendLine("| " + this.Name + " = " + this.Value);
            if (this.Value_bg != null && this.Name != "virus_group") taxon.AppendLine("| " + this.Name + "-bg = " + this.Value_bg);

            return taxon.ToString();
        }
    }
}
