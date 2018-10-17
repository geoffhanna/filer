using filerLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace filer.Test
{
    [TestClass]
    public class PaperEntityTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var paper = new PaperEntity();
            paper.Name = "geoff";
            paper.HangingFolderGroup = "x";
            var x = paper.RowKey;
        }
    }
}
