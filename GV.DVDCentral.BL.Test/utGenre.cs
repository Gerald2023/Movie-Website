namespace GV.DVDCentral.BL.Test
{
    [TestClass]
    public class utGenre
    {
        [TestMethod]
        public void LoadTest()
        {

            Assert.AreEqual(3, GenreManager.Load().Count);
        }
    }
}