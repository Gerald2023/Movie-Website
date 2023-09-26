namespace GV.DVDCentral.BL.Test
{
    [TestClass]
    public class utDirector
    {
        [TestMethod]
        public void LoadTest()
        {

            Assert.AreEqual(3, DirectorManager.Load().Count);
        }
    }
}