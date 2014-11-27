namespace Wiki.Tester
{
    using ArtOfTest.WebAii.TestTemplates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Wiki.Core.Factory;

    [TestClass]
    public class WikiTester : BaseTest
    {
        [TestInitialize]
        public void TestInitialize()
        {
            this.Initialize();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.CleanUp();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            ShutDown();
        }

        [TestMethod]
        public void Step1_ExportWikiDbToExcel()
        {
            Exporter.TaxoboxToExcel("Sv", 310000, 1000, 10000);
        }

        [TestMethod]
        public void Step2_UnifyExcelFiles()
        {
            Unifier.GetColumnNames("En");
            Unifier.CreateUnitedTable("En");
        }

        [TestMethod]
        public void Step3_GenerateArticles()
        {
            Builder.GenerateArticles(base.Log);
        }
    }
}