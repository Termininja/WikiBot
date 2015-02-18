namespace Wiki.Models.Wikidata.Statements
{
    using System;

    using MinimalJson;
    using Wiki.Models.Enums;

    public abstract class Statement
    {
        private const string MainsnakSnakType = "value";
        private const string DataType = "statement";
        private const string DataRank = "normal";

        private string itemID;
        private JsonObject data;

        //protected JsonArray references;
        protected JsonObject mainsnak;
        protected JsonObject datavalue;
        protected JsonObject value;

        private Statement(string itemID)
        {
            this.itemID = itemID;
        }

        public Statement(string itemID, string dataValueType)
            : this(itemID)
        {
            this.value = new JsonObject();
            this.datavalue = new JsonObject();
            this.mainsnak = new JsonObject();
            //this.references = new JsonArray();
            this.Data = new JsonObject();

            this.datavalue
                .add("type", dataValueType)
                .add("value", this.value);

            this.mainsnak
                .add("snaktype", MainsnakSnakType)
                .add("property", this.Property)
                .add("datavalue", this.datavalue);

            this.Data
                .add("type", DataType)
                .add("mainsnak", this.mainsnak)
                .add("id", this.itemID + "$" + Guid.NewGuid())
                .add("rank", DataRank);
        }

        public Statement(string itemID, JsonObject data)
            : this(itemID)
        {
            this.Data = data;
        }

        public string Property
        {
            get
            {
                return "P" + (int)(PropertyType)Enum.Parse(typeof(PropertyType), this.GetType().Name, true);
            }
        }

        public JsonObject Data
        {
            get
            {
                return this.data;
            }
            set
            {
                if (value != null)
                {
                    this.data = value;
                    var m = this.data.get("mainsnak");
                    if (m != null)
                    {
                        this.mainsnak = m.asObject();
                        var d = this.mainsnak.get("datavalue");
                        if (d != null)
                        {
                            this.datavalue = d.asObject();
                            var v = this.datavalue.get("value");
                            if (v != null)
                            {
                                this.value = v.asObject();
                            }
                        }
                    }
                }
            }
        }

        protected void UpdateData(JsonObject value)
        {
            this.datavalue.set("value", value);
            this.mainsnak.set("datavalue", this.datavalue);
            this.Data.set("mainsnak", this.mainsnak);
            //this.Data.set("references", this.references);
        }
    }
}