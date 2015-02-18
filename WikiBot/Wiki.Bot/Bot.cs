namespace Wiki.Bot
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    using Wiki.Core;
    using Wiki.Core.Access;
    using Wiki.Models.Enums;
    using Wiki.Models.Wikidata.Statements;
    using Wiki.Models.Wikipedia.Pages.MainPages;
    using Wiki.Models.Wikipedia.Pages.ResultsPages;

    public class Bot
    {
        public static void Main()
        {
            var wikidataPassword = Console.ReadLine(); Console.Clear();
            var wikidata = new Wikidata("BotNinja", wikidataPassword);

            MoveDatesInWikidata(wikidata);

            #region Tests

            //WikidataTest();

            //wikidata.AddLink("Sinobdella sienensis");
            //wikidata.AddProperty<DateOfBirth>("Христо Ботев", "+00000002222-02-22T00:00:00Z", 11);

            //var itemID = wikidata.GetItemID("Атанас Калчев");
            //var dateOfDeath = new DateOfDeath(itemID, "+00000001980-05-21-T00:00:00Z", 11);
            //wikidata.AddProperty("Атанас Калчев", PropertyType.DateOfDeath, "+00000001111-11-11T00:00:00Z", 11, "test");

            {
                //AdvisorEditor.Check(3500, 12, 10);
                //DataConverter.ExcelToDB(@"..\..\..\Taxons.xlsx", "Taxons", "taxonID", "name", "authority", "synonyms", "acronyms");
            }

            {
                //ArticleEditor.FindInterlanguageLinks();

                //Replace "Василев" with "Василиев" in all pages in search results for "Български възрожденски майстори"
                //ArticleEditor.ReplaceStringInSearchResults("\"Български възрожденски майстори\"", "Василев", "Василиев");
            }

            {
                //ArticleChecker.Check();

                //ArticleGenerator.TemplatetigerToExcel(Lang.en, 1000);
                //ArticleGenerator.ExcelToWikiArticle(username, password);
            }

            //var link = "Шаблон:Потребител 1000";
            //ArticleEditor.ReplaceStringInWhatLinksHereResults(link, "1000", "Потребителска кутия|1000");

            //GenerateWikiArticle_v2();

            //ArticlesEditorFromCategory.Edit("Уикипедия:Видове_растения");
            //CategoriesEditor.Edit("TEMP");

            //EditArticlesFromLinks();
            //WhatLinksHereEditor2.Edit("Опосуми");

            //DBExporter.ExportFromIUCN("http://www.iucnredlist.org/details/{0}/0");
            //DBExporter.UpdateIUCNDatabase("http://www.iucnredlist.org/details/{0}/0");

            #endregion
        }

        private static void MoveDatesInWikidata(Wikidata wikidata)
        {
            int good = 0;
            int bad = 0;

            var whatLinksHerePage = new WikiWhatLinksHerePage("Шаблон:Биография инфо", true);
            whatLinksHerePage.Navigate();
            var articles = whatLinksHerePage.GetResults();

            foreach (var articleName in articles)
            {
                try
                {
                    var page = new WikiEditPage(articleName);
                    page.Navigate();

                    var text = page.Textarea;
                    var lines = text.Split('\n');

                    var deathYears = H.GetParameter(lines, "починал-години");
                    var suffix = H.GetParameter(lines, "наставка"); var realSuffix = "";
                    var birthDate = H.GetParameter(lines, "роден-дата"); var realBirthDate = ""; var birthPrecision = 11;
                    var deathDate = H.GetParameter(lines, "починал-дата"); var realDeathDate = ""; var deathPrecision = 11;

                    if (deathYears != null || suffix != null || birthDate != null || deathDate != null)
                    {
                        if (deathYears != null)
                        {
                            H.CheckForInnerTemplate(deathYears);
                        }
                        if (suffix != null)
                        {
                            H.CheckForInnerTemplate(suffix);
                            realSuffix = H.FormatSuffix(suffix);
                        }
                        if (birthDate != null)
                        {
                            H.CheckForInnerTemplate(birthDate);
                            realBirthDate = H.FormatDate(birthDate, ref birthPrecision);
                        }
                        if (deathDate != null)
                        {
                            H.CheckForInnerTemplate(deathDate);
                            realDeathDate = H.FormatDate(deathDate, ref deathPrecision);
                        }

                        if (realSuffix == null || realBirthDate == null || realDeathDate == null) throw new System.Exception("");

                        if (!string.IsNullOrEmpty(realSuffix))
                            wikidata.AddProperty<SexOrGender>(articleName, realSuffix, 0, "Added property [sex or gender]: " + realSuffix + "; moved from bgwiki");
                        if (!string.IsNullOrEmpty(realBirthDate))
                            wikidata.AddProperty<DateOfBirth>(articleName, realBirthDate, birthPrecision, "Added property [date of birth]: " + realBirthDate.Substring(8, 10) + "; moved from bgwiki");
                        if (!string.IsNullOrEmpty(realDeathDate))
                            wikidata.AddProperty<DateOfDeath>(articleName, realDeathDate, deathPrecision, "Added property [date of death]: " + realDeathDate.Substring(8, 10) + "; moved from bgwiki");

                        if (deathYears != null || realSuffix != null || realBirthDate != null || realDeathDate != null)
                        {
                            if (deathYears != null) text = text.Replace("\n" + deathYears, "");
                            if (suffix != null) text = text.Replace("\n" + suffix, "");
                            if (birthDate != null) text = text.Replace("\n" + birthDate, "");
                            if (deathDate != null) text = text.Replace("\n" + deathDate, "");

                            page.Textarea = text;
                            page.Summary = "Преместване на параметри от Шаблон:Биография инфо в [[:wikidata:Wikidata:Main_Page|Уикиданни]]";
                            page.Save();
                        }

                        Console.Log(articleName + " (" + good + ")", true);
                    }
                    else
                    {
                        Console.Log(articleName + " (" + good + ")");
                    }

                    good++;
                }
                catch (System.Exception ex)
                {
                    Console.OnFocus();

                    if (ex.Message != "Different dates")
                    {
                        bad++;

                        var log = articleName + (string.IsNullOrEmpty(ex.Message) ? "" : " - Exception: " + ex.Message);
                        FileAccess.WriteText(log, @"..\..\..\Report.log");
                    }

                    Console.Log(articleName + " (" + bad + ") " + ex.Message, false);
                }
            }
        }
    }
}
