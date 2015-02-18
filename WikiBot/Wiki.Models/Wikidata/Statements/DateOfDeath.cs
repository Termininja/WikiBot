namespace Wiki.Models.Wikidata.Statements
{
    using MinimalJson;

    public class DateOfDeath : DateStatement
    {
        public DateOfDeath(string itemID, string time, int precision)
            : base(itemID, time, precision) { }

        public DateOfDeath(string itemID, JsonObject data)
            : base(itemID, data) { }
    }
}