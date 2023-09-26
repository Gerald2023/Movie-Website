using GV.DVDCentral.BL.Models;
using GV.DVDCentral.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GV.DVDCentral.BL
{
    public static class RatingManager
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

        public static Rating LoadById(int id)
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

        public static List<Rating> Load()
        {

            try
            {
                List<Rating> list = new List<Rating>();
                using (DVDCentralEntities dc = new DVDCentralEntities()) // Blocked Scope
                {
                    (from r in dc.tblRatings
                     select new
                     {
                         r.Id,
                         r.Description

                     })
                     .ToList()
                     .ForEach(format => list.Add(new Rating
                     {
                         Id = format.Id,
                         Description = format.Description

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
