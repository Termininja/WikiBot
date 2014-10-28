namespace WikiBot.Models.TaxoBox
{
    using System.Collections.Generic;
    using System.Text;

    public class Taxobox
    {
        private List<Authority> Authorities;

        public Taxobox()
        {
            this.Authorities = new List<Authority>();
        }

        public string Name { get; set; }
        public Image Image { get; set; }

        public Statute Statute { get; set; }
        public FossilRange FossilRange { get; set; }

        public Taxonomy Taxonomy { get; set; }
        public string Hybrid { get; set; }

        public Map Map { get; set; }
        public string Subdivision { get; set; }
        public Diversity Diversity { get; set; }

        public string Synonyms { get; set; }
        public string SynonymsRef { get; set; }

        public string Includes { get; set; }
        public string Excludes { get; set; }

        public void AddAuthority(Authority authority)
        {
            this.Authorities.Add(authority);
        }

        public override string ToString()
        {
            StringBuilder taxobox = new StringBuilder();

            taxobox.AppendLine("{{Taxobox");
            if (this.Name != null) taxobox.AppendLine("| name = " + this.Name);
            if (this.Image != null) taxobox.AppendLine(this.Image.ToString());
            if (this.Statute != null) taxobox.AppendLine(this.Statute.ToString());
            if (this.FossilRange != null) taxobox.AppendLine(this.FossilRange.ToString());
            if (this.Taxonomy != null) taxobox.AppendLine(this.Taxonomy.ToString());
            if (this.Hybrid != null) taxobox.AppendLine("| hybrid = " + this.Hybrid);
            if (this.Authorities.Count > 0)
            {
                foreach (var authority in this.Authorities)
                {
                    taxobox.AppendLine(authority.ToString());
                }
            }
            if (this.Map != null) taxobox.AppendLine(this.Map.ToString());
            if (this.Subdivision != null) taxobox.AppendLine("| subdivision = " + this.Subdivision);
            if (this.Diversity != null) taxobox.AppendLine(this.Diversity.ToString());
            if (this.Synonyms != null) taxobox.AppendLine("| synonyms = " + this.Synonyms);
            if (this.SynonymsRef != null) taxobox.AppendLine("| synonyms_ref = " + this.SynonymsRef);
            if (this.Includes != null) taxobox.AppendLine("| includes = " + this.Includes);
            if (this.Excludes != null) taxobox.AppendLine("| excludes = " + this.Excludes);
            taxobox.AppendLine("}}");

            return taxobox.ToString();
        }
    }
}
