namespace GV.DVDCentral.PL.Test
{
    [TestClass]
    public class utDirector
    {
        

        [TestMethod]
        public void LoadTest()
        {
            DVDCentralEntities di = new DVDCentralEntities(); // This is a new instance of the DVDCentralEntities
            
            Assert.AreEqual(3, di.tblDirectors.Count()); //Assert means Test(I'm gonna test something) // di.tblDirectors is select * from tblDirectors

        }

        [TestMethod]
        public void InsertTest()
        {
            DVDCentralEntities di = new DVDCentralEntities(); // This is a new instance of the DVDCentralEntities

            //Make an entity 

            tblDirector entity = new tblDirector();
            entity.Id = -99;
            entity.FirstName = "Gerald";
            entity.LastName = "Vallejos";

            //add the entity to the database
            di.tblDirectors.Add(entity);

            //commit the changes (insert a record)

            int result = di.SaveChanges(); //di.SaveChanges();
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