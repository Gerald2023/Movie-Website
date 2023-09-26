using GV.DVDCentral.BL.Models;
using GV.DVDCentral.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GV.DVDCentral.BL
{
    public static class GenreManager
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

        public static Genre LoadById(int id)
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

        public static List<Genre> Load()
        {

            try
            {
                List<Genre> list = new List<Genre>();
                using (DVDCentralEntities dc = new DVDCentralEntities()) // Blocked Scope
                {
                    (from g in dc.tblGenres
                     select new
                     {
                         g.Id,
                         g.Description

                     })
                     .ToList()
                     .ForEach(format => list.Add(new Genre
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
