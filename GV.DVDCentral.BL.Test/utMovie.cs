namespace GV.DVDCentral.BL.Test
{
    [TestClass]
    public class utMovie
    {
        [TestMethod]
        public void LoadTest()
        {

            Assert.AreEqual(3, MovieManager.Load().Count);
        }
    }
}