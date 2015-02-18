namespace Wiki.Models.Wikidata.Statements
{
    using System;

    using MinimalJson;
    using Wiki.Models.Enums;

    public class SexOrGender : Statement
    {
        private const string SexOrGenderDataValueType = "wikibase-entityid";
        private const string ValueEntityType = "item";

        /// <summary>
        /// Constructor for "sex or gender" (P21) statement.
        /// </summary>
        /// <param name="itemID">Wikidata item ID.</param>
        /// <param name="sex">The sex: "male" or "female".</param>
        public SexOrGender(string itemID, Sex sex)
            : base(itemID, SexOrGenderDataValueType)
        {
            this.Sex = sex;

            base.value
                .set("entity-type", ValueEntityType)
                .set("numeric-id", (int)this.Sex);
        }

        public SexOrGender(string itemID, JsonObject data)
            : base(itemID, data)
        {
            //if (this.value != null)
            //{
            //    var numericID = this.value.get("numeric-id");
            //    if (numericID != null)
            //    {
            //        this.Sex = (Sex)numericID.asInt();
            //    }
            //}
        }

        public Sex? Sex
        {
            get
            {
                var sex = this.value.get("numeric-id");
                if (sex != null)
                {
                    return (Sex)Enum.Parse(typeof(Sex), sex.asString(), true);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.value.set("numeric-id", (int)value);
                base.UpdateData(this.value);
            }
        }
    }
}
