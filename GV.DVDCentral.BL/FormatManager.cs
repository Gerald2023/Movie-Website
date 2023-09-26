using GV.DVDCentral.BL.Models;
using GV.DVDCentral.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace GV.DVDCentral.BL
{
    public static class FormatManager
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

        public static Format LoadById(int id)
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

        public static List<Format> Load()
        {

            try
            {
                List<Format> list = new List<Format>();
                using (DVDCentralEntities dc = new DVDCentralEntities()) // Blocked Scope
                {
                    (from f in dc.tblFormats
                     select new
                     {
                         f.Id,
                         f.Description
                         
                     })
                     .ToList()
                     .ForEach(format => list.Add(new Format
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
