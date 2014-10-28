namespace WikiBot.Models.TaxoBox
{
    using System.Text;

    public class Map
    {
        public string RangeMap { get; set; }

        public string RangeMapCaption { get; set; }

        public Map(string map, string caption)
        {
            this.RangeMap = map;
            this.RangeMapCaption = caption;
        }

        public override string ToString()
        {
            StringBuilder map = new StringBuilder();

            //TODO

            return map.ToString();
        }
    }
}
