namespace Wiki.Models.Wikidata.Statements
{
    using MinimalJson;

    public class DateOfBirth : DateStatement
    {
        public DateOfBirth(string itemID, string time, int precision)
            : base(itemID, time, precision) { }

        public DateOfBirth(string itemID, JsonObject data)
            : base(itemID, data) { }
    }
}