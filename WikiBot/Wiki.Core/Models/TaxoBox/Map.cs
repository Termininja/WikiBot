namespace Wiki.Core.Models.TaxoBox
{
    using System.Text;

    public class Map
    {
        private string rangeMap;

        private string rangeMapCaption;

        public Map(string map, string caption)
        {
            this.rangeMap = map;
            this.rangeMapCaption = caption;
        }

        public override string ToString()
        {
            StringBuilder map = new StringBuilder();

            if (this.rangeMap != null) map.AppendLine("| range_map = " + this.rangeMap);
            if (this.rangeMapCaption != null) map.AppendLine("| range_map_caption = " + this.rangeMapCaption);

            return map.ToString();
        }
    }
}
