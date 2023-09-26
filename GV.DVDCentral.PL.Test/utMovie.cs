namespace GV.DVDCentral.PL.Test
{
    [TestClass]
    public class utMovie
    {
        //Modular or class level scope
        protected DVDCentralEntities dc;// Declared it. It is intantiated it on line 14. 
        protected IDbContextTransaction transaction;

        [TestInitialize] // This is a method attribute, it is used to set up for the test.  It is run before each test.
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
            //DVDCentralEntities dc = new DVDCentralEntities(); // This is a new instance of the DVDCentralEntities
            Assert.AreEqual(3, dc.tblMovies.Count()); //Assert means Test(I'm gonna test something) // di.tblMovies is select * from tblMovies

        }

        [TestMethod]
        public void InsertTest()
        {
            // DVDCentralEntities di = new DVDCentralEntities(); // This is a new instance of the DVDCentralEntities

            //Make an entity 

            tblMovie entity = new tblMovie();
            entity.Id = -99;
            entity.Title = "The Fight Club";
            entity.Descripition = "Rule1. You do not talk about the fight club";
            entity.Cost = 20.5m; //To do: Fix the datatype of cost to double or  float on dbo.tblMovie. Then change recreate the local 
            entity.RatingId = -99;
            entity.FormatId = -99;
            entity.DirectorId = -99;
            entity.InStkQty = 60;
            entity.ImagePath = "fight_club.jpg";



            //add the entity to the database
            dc.tblMovies.Add(entity);

            //commit the changes (insert a record)

            int result = dc.SaveChanges(); //dc.SaveChanges();
            Assert.AreEqual(1, result);

        }



        
        [TestMethod]
        public void UpdateTest()
        {
            tblMovie entity = dc.tblMovies.FirstOrDefault();

            //change property values
            entity.Title = "Changed the title of this movie";
            entity.Descripition = "Changed the description of this movie";


            int result = dc.SaveChanges();
            Assert.IsTrue(result > 0);

        }

        [TestMethod]
        public void DeleteTest()
        {
          
            tblMovie entity = dc.tblMovies.Where(e => e.Id == 2).FirstOrDefault();

            //remove the entity
            dc.tblMovies.Remove(entity);
            int result = dc.SaveChanges();
            Assert.AreNotEqual(result, 0);
        }
    }
}