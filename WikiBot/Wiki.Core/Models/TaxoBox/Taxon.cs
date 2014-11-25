namespace Wiki.Core.Models.TaxoBox
{
    public class Taxon
    {
        public string Name { get; set; }

        public string Name_bg { get; set; }

        public Taxon(string name, string name_bg)
        {
            this.Name = name;
            this.Name_bg = name_bg;
        }
    }
}
