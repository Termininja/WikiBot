namespace Wiki.Core.Models.TaxoBox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Taxonomy
    {
        private List<Taxon> taxons;

        public Taxonomy()
        {
            this.Ranks = new string[] { 
                "virus_group", "superdomain", "domain", "superregnum", "regnum", "unranked_regnum", "subregnum", 
                "superdivisio", "unranked_superdivisio", "superphylum", "divisio", "unranked_divisio", "phylum", 
                "unranked_phylum", "subdivisio", "subphylum", "infraphylum", "microphylum", "nanophylum",                 
                "superclassis", "classis", "unranked_classis", "subclassis", "infraclassis", "magnordo",
                "superordo", "ordo", "unranked_ordo", "subordo", "infraordo", "parvordo", "superfamilia", 
                "familia", "unranked_familia", "subfamilia", "supertribus", "tribus", "subtribus", "alliance", 
                "genus", "subgenus", "sectio", "series", "species", "subspecies", "variety" };

            this.Ranks_bg = new string[] { 
                "група", "надимперия", "империя", "надцарство", "царство", "(царство без ранг)", "подцарство", 
                "надотдел", "(надотдел без ранг)", "надтип", "отдел", "(отдел без ранг)", "тип",
                "(тип без ранг)", "подотдел", "подтип", "инфратип", "микротип", "нанотип", 
                "надклас", "клас", "(клас без ранг)", "подклас", "инфраклас", "магнразред", 
                "надразред", "разред", "(разред без ранг)", "подразред", "инфраразред", "парвразред", "надсемейство", 
                "семейство", "(семейство без ранг)", "подсемейство", "надтриб", "триб", "подтриб", "алианс", 
                "род", "подрод", "секция", "серия", "вид", "подвид", "вариетет" };

            this.taxons = new List<Taxon>();
            for (int i = 0; i < this.Ranks.Length; i++)
            {
                this.taxons.Add(new Taxon(this.Ranks[i], this.Ranks_bg[i]));
            }
        }

        public string[] Ranks { get; set; }

        public string[] Ranks_bg { get; set; }

        public void AddTaxon(string rank, string value, string value_bg)
        {
            var index = this.taxons.IndexOf(this.taxons.FirstOrDefault(x => x.Name == rank));
            this.taxons[index].Value = value;
            this.taxons[index].Value_bg = value_bg;
        }

        public Taxon GetRank()
        {
            return this.taxons.FindLast(x => x.Value != null);
        }

        internal string GetText(string articleName)
        {
            StringBuilder text = new StringBuilder();
            string qmarks = "'''";
            string rank = this.GetRank().Name_bg;//new Rank()
            Taxon upperRank = new Taxon(null, null);// this.GetUpperRank();
            bool plural = true;

            var index = Array.IndexOf(this.Ranks_bg, rank);
            if (index >= Array.IndexOf(this.Ranks_bg, "род")) qmarks += "''";
            if (index >= Array.IndexOf(this.Ranks_bg, "вид")) plural = false;

            // For Edit: Validation for "rank" and "upperRank"
            text.AppendLine(
                qmarks + articleName + qmarks + ((plural) ? " са " : " е ") + rank +
                "{бозайници, насекоми, гъби, гъба, риба}" + " от " + upperRank.Name_bg + " " +
                upperRank.Value_bg + " [[" + upperRank.Value + "]]");

            return text.ToString();
        }

        public override string ToString()
        {
            StringBuilder taxonomy = new StringBuilder();

            foreach (var taxon in this.taxons)
            {
                if (taxon.Value != null) taxonomy.Append(taxon.ToString());
            }

            return taxonomy.ToString();
        }
    }
}