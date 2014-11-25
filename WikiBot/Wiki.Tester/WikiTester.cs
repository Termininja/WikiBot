namespace Wiki.Tester
{
    using ArtOfTest.WebAii.TestTemplates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Wiki.Core;

    [TestClass]
    public class WikiTester : BaseTest
    {
        public TestContext TestContext { get; set; }
        public Exporter Exporter { get; set; }
        public Builder Builder { get; set; }

        #region Initialize & Cleanup

        [TestInitialize]
        public void TestInitialize()
        {
            this.Initialize(false, this.TestContext.TestLogsDir, new TestContextWriteLine(this.TestContext.WriteLine));
            this.SetTestMethod(this, (string)TestContext.Properties["TestName"]);
            this.Exporter = new Exporter();
            this.Builder = new Builder();
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

        #endregion

        [TestMethod]
        public void ExportEnWiki()
        {
            this.Exporter.TaxoboxToExcel("En", 200000, 1000, 10000);
        }

        [TestMethod]
        public void ExportSvWiki()
        {
            this.Exporter.TaxoboxToExcel("Sv", 200000, 1000, 10000);
        }

        [TestMethod]
        public void GenerateArticles()
        {
            this.Builder.GenerateArticles(base.Log);
        }
    }
}