namespace Wiki.Core.Models.TaxoBox
{
    using System.Linq;
    using System.Text;

    public class FossilRange
    {
        public string Input { get; set; }

        public override string ToString()
        {
            string fossilRange = "{{";

            decimal start = decimal.Parse(this.Input.Substring(0, 1));      //For edit
            decimal end = decimal.Parse(this.Input.Substring(0, 1));        //For edit
            decimal earliest = decimal.Parse(this.Input.Substring(0, 1));   //For edit
            decimal latest = decimal.Parse(this.Input.Substring(0, 1));     //For edit
            string reference = this.Input.Substring(0, 1);                  //For edit

            if (start < 2.588m) fossilRange += "mini ";
            else if (start < 65.5m) fossilRange += "short ";
            else if (start < 541m) fossilRange += string.Empty;
            else fossilRange += "long ";

            fossilRange += "fossil range";

            if (start != null) fossilRange += "|" + start;
            if (end != null) fossilRange += "|" + end;
            if (earliest != null) fossilRange += "|earliest=" + earliest;
            if (latest != null) fossilRange += "|latest=" + latest;
            if (reference != null) fossilRange += "|ref=" + reference;

            fossilRange += "}}";

            return fossilRange;
        }
    }
}