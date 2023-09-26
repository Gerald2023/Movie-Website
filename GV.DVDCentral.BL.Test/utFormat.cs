namespace GV.DVDCentral.BL.Test
{
    [TestClass]
    public class utFormat
    {
        [TestMethod]
        public void LoadTest()
        {

            Assert.AreEqual(3, FormatManager.Load().Count);
        }
    }
}