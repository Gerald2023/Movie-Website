using GV.DVDCentral.BL.Models;
using GV.DVDCentral.PL;
using Microsoft.EntityFrameworkCore.Storage;

namespace GV.DVDCentral.BL
{
    public static class MovieManager
    {
        public static int Insert(string title, 
                                string description,
                                double cost,
                                int ratingId,
                                int directorId,
                                int formatId,
                                int inStkQty,
                                string imagePath,
                                ref int id,
                                bool rollback = false)
        {
            try
            {
                Movie movie = new Movie();
                {
                    movie.Title = title;
                    movie.Description = description;
                    movie.Cost = cost;
                    movie.RatingId = ratingId;
                    movie.FormatId = formatId;
                    movie.DirectorId = directorId;
                    movie.InStkQty = inStkQty;
                    movie.ImagePath = imagePath;

                };

                int results = Insert(movie, rollback);

                //IMPORTANT - BACKFILL THE REFERENCE ID
                id = movie.Id;

                return results;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static int Insert(Movie movie, bool rollback = false)
        {


            try
            {
                int results = 0;

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblMovie entity = new tblMovie();
                    entity.Id = dc.tblMovies.Any() ? dc.tblMovies.Max(m => m.Id) + 1 : 1;

                    entity.Title = movie.Title;
                    entity.Description = movie.Description;
                    entity.Cost = movie.Cost;
                    entity.RatingId = movie.RatingId;
                    entity.FormatId = movie.FormatId;
                    entity.DirectorId = movie.DirectorId;
                    entity.InStkQty = movie.InStkQty;
                    entity.ImagePath = movie.ImagePath;



                    //IMPORTANT - BACK FILL THE ID
                    movie.Id = entity.Id;

                    dc.tblMovies.Add(entity);
                    results = dc.SaveChanges();

                    if (rollback) transaction.Rollback();
                }

                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Update(Movie movie, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities()) //blocked scope
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();


                    //Get the row that we are trying to update
                    tblMovie entity = dc.tblMovies.FirstOrDefault(m => m.Id == movie.Id);

                    if (entity != null)
                    {
                        entity.Title = movie.Title;
                        entity.Description = movie.Description;


                        results = dc.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Row does not exist");
                    }
                    if (rollback) transaction.Rollback();

                }
                return results;
            }
            catch (Exception)
            {

                throw;
            }


        }


        public static int Delete(int id, bool rollback = false)
        {


            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities()) //blocked scope
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();


                    //Get the row that we are trying to delete
                    tblMovie entity = dc.tblMovies.FirstOrDefault(m => m.Id == id);

                    if (entity != null)
                    {
                        dc.tblMovies.Remove(entity);
                        results = dc.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Row does not exist");
                    }
                    if (rollback) transaction.Rollback();

                }
                return results;
            }
            catch (Exception)
            {

                throw;
            }



        }

        public static Movie LoadById(int id)
        {
            try
            {


                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    tblMovie entity = dc.tblMovies.FirstOrDefault(d => d.Id == id);
                    if (entity != null)
                    {
                        return new Movie
                        {

                           Id = entity.Id,
                           Title = entity.Title,
                           Description = entity.Description,
                           Cost = entity.Cost,
                           RatingId = entity.RatingId,
                           FormatId = entity.FormatId,
                           DirectorId = entity.DirectorId,
                           InStkQty = entity.InStkQty,
                           ImagePath = entity.ImagePath

                         
                        };
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Movie> Load()
        {

            try
            {
                List<Movie> list = new List<Movie>();
                using (DVDCentralEntities dc = new DVDCentralEntities()) // Blocked Scope
                {
                    (from m in dc.tblMovies
                     select new
                     {
                         m.Id,
                         m.Title,
                         m.Description,
                         m.Cost,
                         m.RatingId,
                         m.FormatId, 
                         m.DirectorId,
                         m.InStkQty,
                         m.ImagePath,

                     })
                     .ToList()
                     .ForEach(movie => list.Add(new Movie
                     {
                         
                         Id = movie.Id,
                         Title = movie.Title,
                         Description = movie.Description,
                         Cost = movie.Cost,
                         RatingId = movie.RatingId,
                         FormatId = movie.FormatId,
                         DirectorId = movie.DirectorId,
                         InStkQty = movie.InStkQty,
                         ImagePath = movie.ImagePath


                     }));
                }

                return list;
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
