namespace GV.DVDCentral.PL.Test
{
    [TestClass]
    public class utFormat
    {

        //Modular or class level scope
        protected DVDCentralEntities dc;// Declared it. It is intantiated it on line 14. 
        protected IDbContextTransaction transaction;


        [TestInitialize]
        public void Initialize()
        {
            dc = new DVDCentralEntities(); // Instantiated from protected DVDCentralEntities di;
            transaction = dc.Database.BeginTransaction();

        }

        [TestCleanup]
        public void Cleanup()
        {
            transaction.Rollback();
            transaction.Dispose(); // to clean the memory
            dc = null;  

        }
       
        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(3, dc.tblFormats.Count()); 

        }

        [TestMethod]
        public void InsertTest()
        {
            // Make an entity
            tblFormat entity = new tblFormat(); 

            entity.Id = -99;
            entity.Description = "MP4";

            // add entity to database

            dc.tblFormats.Add(entity);

            //commit the changes (insert a record)

            int result = dc.SaveChanges(); //dc.SaveChanges();
            Assert.AreEqual(1, result);



        }



        [TestMethod]
        public void UpdateTest()
        {

        }

        [TestMethod]
        public void DeleteTest()
        {

        }
    }
}