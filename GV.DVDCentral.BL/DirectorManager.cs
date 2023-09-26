using GV.DVDCentral.PL;
using GV.DVDCentral.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GV.DVDCentral.BL
{
    public static class DirectorManager
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

        public static Director LoadById(int id)
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

        public static List<Director> Load()
        {

            try
            {
                List<Director> list = new List<Director>();
                using (DVDCentralEntities dc = new DVDCentralEntities()) // Blocked Scope
                {
                    (from d in dc.tblDirectors
                     select new
                     {
                         d.Id,
                         d.FirstName,
                         d.LastName
                         


                     })
                     .ToList()
                     .ForEach(format => list.Add(new Director
                     {
                        Id = format.Id,
                        FirstName = format.FirstName,
                        LastName = format.LastName

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
