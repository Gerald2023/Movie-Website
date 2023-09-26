namespace GV.DVDCentral.BL.Test
{
    [TestClass]
    public class utRating
    {
        [TestMethod]
        public void LoadTest()
        {

            Assert.AreEqual(4, RatingManager.Load().Count);
        }
    }
}