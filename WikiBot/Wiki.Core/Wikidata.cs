namespace Wiki.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MinimalJson;
    using Wiki.Models.Enums;
    using Wiki.Models.Wikidata.Statements;
    using Wiki.Core.Access;

    public class Wikidata
    {
        private string itemID;
        private string label;
        private int revisionID;
        private int sitelinks;
        private JsonObject claims;
        private WebAccess web;
        private Statement newProperty;
        private Statement oldProperty;

        public Wikidata(string loginUsername = null, string loginPassword = null)
        {
            this.web = new WebAccess("https://www.wikidata.org/w/api.php?");

            if (loginUsername != null)
            {
                this.Login(loginUsername, loginPassword);
            }
        }

        public string Label
        {
            get
            {
                return this.label;
            }
        }

        public int Sitelinks
        {
            get
            {
                return this.sitelinks;
            }
        }


        /// <summary>
        /// Adds some bgwiki page to an existing (or will create new one) Wikidata item.
        /// </summary>
        /// <param name="wikidataPageName">Some page name already included in the Wikidata item.</param>
        /// <param name="bgwikiPageName">The bgwiki page's name. By default it is the same as wikidataPageName.</param>
        public void AddLink(string wikidataPageName, string bgwikiPageName = null)
        {
            var pageName = bgwikiPageName ?? wikidataPageName;

            if (this.GetItemID(wikidataPageName) != null)
            {
                var bgwiki = new JsonObject().add("site", "bgwiki").add("title", pageName);
                var sitelinks = new JsonObject().set("bgwiki", bgwiki);
                var data = new JsonObject().set("sitelinks", sitelinks);

                this.Save("wbeditentity", data.ToString(), "Added link to [bgwiki]: " + pageName);
            }
            else
            {
                this.CreatePage(pageName);
            }
        }

        /// <summary>
        /// Adds some property to an existing item in Wikidata which include some bgwiki page.
        /// </summary>
        /// <param name="bgwikiPageName">The name of the bgwiki page in Wikidata.</param>
        /// <param name="propertyType">The type of the property.</param>
        /// <param name="value">The value of the property.</param>
        /// <param name="precision">The precision (when the property is some date).</param>
        /// <param name="summary">Some edit summary. By default is generated automatically from Wikidata.</param>
        public void AddProperty<T>(string bgwikiPageName, string value, int precision, string summary = null) where T : Statement
        {
            if (this.GetItemID(bgwikiPageName, new List<string>() { "bgwiki" }) != null)
            {
                // TODO: For edit
                #region Check old property and update when need

                var propertyType = (PropertyType)Enum.Parse(typeof(PropertyType), typeof(T).Name, true);
                switch (propertyType)
                {
                    case PropertyType.DateOfBirth:
                        this.newProperty = new DateOfBirth(this.itemID, value, precision); break;
                    case PropertyType.DateOfDeath:
                        this.newProperty = new DateOfDeath(this.itemID, value, precision); break;
                    case PropertyType.SexOrGender:
                        this.newProperty = new SexOrGender(this.itemID, (Sex)Enum.Parse(typeof(Sex), value, true)); break;
                    default: break;
                }

                if (this.claims != null)
                {
                    var oldSSS = this.claims.get(newProperty.Property);
                    if (oldSSS != null)
                    {
                        this.oldProperty = (T)Activator.CreateInstance(typeof(T), this.itemID, oldSSS.asArray()[0].asObject());

                        #region Update the old property

                        if (typeof(T).BaseType == typeof(DateStatement))
                        {
                            var oldSt = (DateStatement)oldProperty;
                            var newSt = (DateStatement)newProperty;

                            var oldDate = (oldSt.Time != null) ? oldSt.Time.ToString().Replace("\"", "") : null;
                            var oldPrecision = oldSt.Precision;

                            #region Log the different dates

                            if ((oldPrecision == precision && value != oldDate && oldPrecision == 11) ||
                                (oldPrecision == precision && value.Substring(8, 4) != oldDate.Substring(8, 4) && oldPrecision == 9) ||
                                (oldPrecision == precision && value.Substring(8, 7) != oldDate.Substring(8, 7) && oldPrecision == 10))
                            {
                                var log = "|-\n" + string.Format("|[[{0}||{1}||[[:wikidata:{2}|{3}]]",
                                    bgwikiPageName + "]]" + (propertyType == PropertyType.DateOfBirth ? " (b)" : " (d)"),
                                    value.Substring(8, oldPrecision == 11 ? 10 : (oldPrecision == 9 ? 4 : 7)), this.itemID,
                                    oldDate.Substring(8, oldPrecision == 11 ? 10 : (oldPrecision == 9 ? 4 : 7)));

                                FileAccess.WriteText(log, @"..\..\..\DifferentDates.log");

                                // To not make changes!
                                throw new System.Exception("Different dates");
                            }

                            #endregion

                            // Updates only for articles with better precision
                            if (/* this.Sitelinks < 2 && */ oldPrecision < precision)
                            {
                                oldSt.Time = value;
                                oldSt.Precision = precision;

                                this.Save("wbsetclaim", oldProperty.Data.asArray()[0].asObject().ToString(), summary);
                            }
                        }
                        else if (typeof(T) == typeof(SexOrGender))
                        {
                            var oldSt = (SexOrGender)oldProperty;
                            var newSt = (SexOrGender)newProperty;
                            if (oldSt.Sex != newSt.Sex)
                            {
                                Console.Log("Probably wrong sex", false);
                                Console.ReadKey();

                                oldSt.Sex = newSt.Sex;

                                this.Save("wbsetclaim", oldSt.Data.asArray()[0].asObject().ToString(), summary);
                            }
                        }

                        #endregion
                    }
                    else this.Save("wbsetclaim", newProperty.Data.ToString(), summary);
                }
                else this.Save("wbsetclaim", newProperty.Data.ToString(), summary);

                #endregion
            }
            else
            {
                this.CreatePage(bgwikiPageName);
            }
        }

        /// <summary>
        /// Gets the Wikidata item ID from any page title which exist in a given list of sites.
        /// </summary>
        /// <param name="title">The Wikidata page's title.</param>
        /// <param name="sites">The list of sites which will be checked for the page's title. By default are all from enum Lang.</param>
        /// <returns>Returns the ID of the found Wikidata item.</returns>
        public string GetItemID(string title, List<string> sites = null)
        {
            this.label = string.Empty;

            if (sites == null)
            {
                sites = new List<string>();
                typeof(Lang).GetEnumValues().Cast<Lang>().ToList().ForEach(m => sites.Add(m + "wiki"));
            }

            var parameters = new Dictionary<string, string>();
            parameters["action"] = "wbgetentities";
            parameters["sites"] = string.Join("|", sites);
            parameters["titles"] = title;
            parameters["format"] = "json";

            var result = JsonValue.readFrom(this.web.Get(parameters)).asObject();
            foreach (JsonObject.Member member in result.get("entities").asObject())
            {
                var data = member.value.asObject();
                if (data.get("missing") == null)
                {
                    this.itemID = data.get("id").asString();
                    this.revisionID = data.get("lastrevid").asInt();
                    this.sitelinks = data.get("sitelinks").asObject().size();
                    this.claims = data.get("claims") != null ? data.get("claims").asObject() : null;

                    var labels = data.get("labels");
                    if (labels != null)
                    {
                        var en = labels.asObject().get("en");
                        if (en != null)
                        {
                            this.label = en.asObject().get("value").asString();
                        }
                    }

                    return this.itemID;
                }
            }

            return null;
        }

        /// <summary>
        /// Creates a new Wikidata page and adds some bgwiki page to it.
        /// </summary>
        /// <param name="bgwikiPageName">The bgwiki page's name.</param>
        /// <param name="title">The title of the Wikidata page.</param>
        public void CreatePage(string bgwikiPageName, string title = null)
        {
            // Create data
            var bgwiki = new JsonObject().add("site", "bgwiki").add("title", bgwikiPageName);
            var sitelinks = new JsonObject().set("bgwiki", bgwiki);
            var data = new JsonObject();

            if (title != null)
            {
                var enLabel = new JsonObject().add("language", "en").add("value", title);
                var labels = new JsonObject().set("en", enLabel);
                data.set("labels", labels);
            }

            data.set("sitelinks", sitelinks);

            // Create request
            var parameters = new Dictionary<string, string>();
            parameters["action"] = "wbeditentity";
            parameters["summary"] = "Created a new item: " + (title ?? bgwikiPageName);

            var body = new Dictionary<string, string>();
            body["new"] = "item";
            body["token"] = this.GetToken();
            body["data"] = data.ToString();

            this.web.Post(parameters, body);
        }

        private void Login(string username, string password)
        {
            var parameters = new Dictionary<string, string>();
            parameters["action"] = "login";
            parameters["format"] = "json";

            var body = new Dictionary<string, string>();
            body["lgname"] = username;
            body["lgpassword"] = password;

            var login = JsonObject.readFrom(this.web.Post(parameters, body)).get("login").asObject();
            body["lgtoken"] = login.get("token").asString();

            this.web.Post(parameters, body);
        }

        private void Save(string action, string data, string summary)
        {
            var parameters = new Dictionary<string, string>();
            parameters["action"] = action;
            parameters["format"] = "json";
            parameters["baserevid"] = this.revisionID.ToString();
            parameters["bot"] = true.ToString();

            var body = new Dictionary<string, string>();
            body["id"] = this.itemID;
            body["token"] = this.GetToken();

            if (summary != null) parameters["summary"] = summary;
            if (action == "wbsetclaim") parameters["claim"] = data;
            if (action == "wbeditentity") body["data"] = data;

            this.web.Post(parameters, body);
        }

        private string GetToken()
        {
            var parameters = new Dictionary<string, string>();
            parameters["action"] = "query";
            parameters["prop"] = "info";
            parameters["intoken"] = "edit";
            parameters["titles"] = "Main Page";
            parameters["format"] = "json";

            var response = this.web.Get(parameters);
            var query = JsonValue.readFrom(response).asObject().get("query").asObject();
            var page = (JsonObject.Member)query.get("pages").asObject().Cast<object>().First();
            var token = page.value.asObject().get("edittoken").asString();

            return token;
        }
    }
}
