using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace filer.Test
{
    [TestClass]
    public class TableAccessTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var clt = filerLibrary.TableAccess.GetTable("deleteme");
            Assert.IsNotNull(clt);

        }
    }
}
