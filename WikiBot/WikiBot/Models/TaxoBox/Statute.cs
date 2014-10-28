namespace WikiBot.Models.TaxoBox
{
    using System.Text;

    public class Statute
    {
        public string Status { get; set; }

        public string StatusSystem { get; set; }

        public string StatusRef { get; set; }

        public string Extinct { get; set; }

        public override string ToString()
        {
            StringBuilder statute = new StringBuilder();
            if (this.Status != null) statute.AppendLine("| status = " + this.Status);
            if (this.StatusSystem != null) statute.AppendLine("| status_system = " + this.StatusSystem);
            if (this.StatusRef != null) statute.AppendLine("| status_ref = " + this.StatusRef);
            if (this.Extinct != null) statute.AppendLine("| extinct = " + this.Extinct);

            return statute.ToString();
        }
    }
}
