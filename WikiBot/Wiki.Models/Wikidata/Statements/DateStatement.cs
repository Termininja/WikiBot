namespace Wiki.Models.Wikidata.Statements
{
    using MinimalJson;

    public abstract class DateStatement : Statement
    {
        private const string CalendarModel = "http://www.wikidata.org/entity/Q1985727";
        private const string DateDataValueType = "time";

        public DateStatement(string itemID, string time, int precision)
            : base(itemID, DateDataValueType)
        {
            this.Time = time;
            this.Precision = precision;

            base.value
                .set("time", this.Time)
                .set("timezone", 0)
                .set("before", 0)
                .set("after", 0)
                .set("precision", this.Precision)
                .set("calendarmodel", CalendarModel);

            #region TODO: References
            //var refValue = new JsonObject()
            //    .set("entity-type", "item")
            //    .set("numeric-id", 11913);      // correspond to "Bulgarian Wikipedia" (Article: Q11913)
            //var datavalue = new JsonObject()
            //    .set("type", "wikibase-entityid")
            //    .set("value", refValue);
            //var p143 = new JsonArray();
            //p143[0] = new JsonObject()
            //    .set("snaktype", "value")
            //    .set("property", "P143")        // means "imported from" (Property: P143)
            //    .set("datavalue", datavalue);
            //var snaks = new JsonObject().set("P143", p143);
            //base.references[0] = new JsonObject().set("snaks", snaks);
            #endregion
        }

        public DateStatement(string itemID, JsonObject data)
            : base(itemID, data)
        {
            //if (this.value != null)
            //{
            //    var time = this.value.get("time");
            //    if (time != null)
            //    {
            //        this.Time = time.asString();
            //    }

            //    var precision = this.value.get("precision");
            //    if (precision != null)
            //    {
            //        this.Precision = precision.asInt();
            //    }
            //}
        }

        public string Time
        {
            get
            {
                return this.value.get("time").asString();
            }
            set
            {
                this.value.set("time", value);
                base.UpdateData(this.value);
            }
        }

        public int Precision
        {
            get
            {
                return this.value.get("precision").asInt();
            }
            set
            {
                this.value.set("precision", value);
                base.UpdateData(this.value);
            }
        }
    }
}

