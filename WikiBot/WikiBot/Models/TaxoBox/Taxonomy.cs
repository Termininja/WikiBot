namespace WikiBot.Models.TaxoBox
{
    using System;
    using System.Text;

    public class Taxonomy
    {
        public string VirusGroup { get; set; }

        public Taxon Superdomain { get; set; }
        public Taxon Domain { get; set; }

        public Taxon UnrankedRegnum { get; set; }
        public Taxon Superregnum { get; set; }
        public Taxon Regnum { get; set; }
        public Taxon Subregnum { get; set; }

        public Taxon UnrankedPhylum { get; set; }
        public Taxon Superphylum { get; set; }
        public Taxon Phylum { get; set; }
        public Taxon Subphylum { get; set; }
        public Taxon Infraphylum { get; set; }
        public Taxon Microphylum { get; set; }
        public Taxon Nanophylum { get; set; }

        public Taxon UnrankedSuperdivisio { get; set; }
        public Taxon Superdivisio { get; set; }
        public Taxon Divisio { get; set; }
        public Taxon Subdivisio { get; set; }

        public Taxon UnrankedClassis { get; set; }
        public Taxon Superclassis { get; set; }
        public Taxon Classis { get; set; }
        public Taxon Subclassis { get; set; }
        public Taxon Infraclassis { get; set; }

        public Taxon UnrankedOrdo { get; set; }
        public Taxon Magnordo { get; set; }
        public Taxon Superordo { get; set; }
        public Taxon Ordo { get; set; }
        public Taxon Subordo { get; set; }
        public Taxon Infraordo { get; set; }
        public Taxon Parvordo { get; set; }

        public Taxon UnrankedFamilia { get; set; }
        public Taxon Superfamilia { get; set; }
        public Taxon Familia { get; set; }
        public Taxon Subfamilia { get; set; }

        public Taxon Supertribus { get; set; }
        public Taxon Tribus { get; set; }
        public Taxon Subtribus { get; set; }

        public Taxon Genus { get; set; }
        public Taxon Subgenus { get; set; }

        public Taxon Sectio { get; set; }
        public Taxon Series { get; set; }

        public Taxon Species { get; set; }
        public Taxon Subspecies { get; set; }

        public Taxon Variety { get; set; }

        private string GetRank()
        {
            if (this.Variety != null) return "Variety";
            if (this.Subspecies != null) return "подвид";
            if (this.Species != null) return "вид";
            if (this.Series != null) return "Series";
            if (this.Sectio != null) return "Sectio";
            if (this.Subgenus != null) return "Subgenus";
            if (this.Genus != null) return "Genus";
            if (this.Subtribus != null) return "Subtribus";
            if (this.Tribus != null) return "Tribus";
            if (this.Supertribus != null) return "Supertribus";
            if (this.Subfamilia != null) return "Subfamilia";
            if (this.Familia != null) return "Familia";
            if (this.Superfamilia != null) return "Superfamilia";
            if (this.UnrankedFamilia != null) return "UnrankedFamilia";
            if (this.Parvordo != null) return "Parvordo";
            if (this.Infraordo != null) return "Infraordo";
            if (this.Subordo != null) return "Subordo";
            if (this.Ordo != null) return "Ordo";
            if (this.Superordo != null) return "Superordo";
            if (this.Magnordo != null) return "Magnordo";
            if (this.UnrankedOrdo != null) return "UnrankedOrdo";
            if (this.Infraclassis != null) return "Infraclassis";
            if (this.Subclassis != null) return "Subclassis";
            if (this.Classis != null) return "Classis";
            if (this.Superclassis != null) return "Superclassis";
            if (this.UnrankedClassis != null) return "UnrankedClassis";
            if (this.Subdivisio != null) return "Subdivisio";
            if (this.Divisio != null) return "Divisio";
            if (this.Superdivisio != null) return "Superdivisio";
            if (this.UnrankedSuperdivisio != null) return "UnrankedSuperdivisio";
            if (this.Nanophylum != null) return "Nanophylum";
            if (this.Microphylum != null) return "Microphylum";
            if (this.Infraphylum != null) return "Infraphylum";
            if (this.Subphylum != null) return "Subphylum";
            if (this.Phylum != null) return "Phylum";
            if (this.Superphylum != null) return "Superphylum";
            if (this.UnrankedPhylum != null) return "UnrankedPhylum";
            if (this.Subregnum != null) return "Subregnum";
            if (this.Regnum != null) return "Regnum";
            if (this.Superregnum != null) return "Superregnum";
            if (this.UnrankedRegnum != null) return "UnrankedRegnum";
            if (this.Domain != null) return "Domain";
            if (this.Superdomain != null) return "Superdomain";
            if (this.VirusGroup != null) return "VirusGroup";

            throw new NotImplementedException("Some rank is not implemented!");
        }

        //TODO: Export it in separated class "Content"
        internal string GetText(string articleName)
        {
            StringBuilder text = new StringBuilder();
            string qmarks = "'''";
            string rank = this.GetRank();//new Rank()
            Rank upperRank = new Rank();// this.GetUpperRank();
            bool plural = true;

            if (rank == "Variety" || rank == "подвид" || rank == "вид" || rank == "Series" ||
                rank == "Sectio" || rank == "Subgenus" || rank == "Genus") qmarks += "''";

            if (rank == "Variety" || rank == "подвид" || rank == "вид") plural = false;

            // For Edit: Validation for "rank" and "upperRank"
            text.AppendLine(qmarks + articleName + qmarks + ((plural) ? " са " : " е ") + rank + "{бозайници, насекоми, гъби, гъба, риба}" + " от " + upperRank.Name_bg + " " + upperRank.Value_bg + " [[" + upperRank.Value + "]]");

            return text.ToString();
        }

        public override string ToString()
        {
            StringBuilder taxonomy = new StringBuilder();

            //TODO

            return taxonomy.ToString();
        }
    }
}
