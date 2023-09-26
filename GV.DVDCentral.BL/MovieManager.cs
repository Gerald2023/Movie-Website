using GV.DVDCentral.BL.Models;
using GV.DVDCentral.PL;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GV.DVDCentral.BL
{
    public static class MovieManager
    {
        public static int Insert()
        {
            try
            {
                return 0;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static int Update()
        {
            try
            {
                return 0;
            }
            catch (Exception)
            {

                throw;
            }


        }


        public static int Delete()
        {

            try
            {
                return 0;
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
                return null;
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
                         m.ImagePath

                     })
                     .ToList()
                     .ForEach(format => list.Add(new Movie
                     {
                         Id = format.Id,
                         Title = format.Title,
                         Description = format.Description,
                         Cost = format.Cost,
                         RatingId = format.RatingId,
                         FormatId = format.FormatId,
                         DirectorId = format.DirectorId,
                         InStkQty = format.InStkQty,
                         ImagePath = format.ImagePath

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
