﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GV.DVDCentral.BL.Models
{
    public class Movie
    {

        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public double Cost { get; set; } // Decimal or decimal? 

        public int  RatingId { get; set; }

        public int FormatId { get; set; }

        public int DirectorId { get; set; }

        public int InStkQty { get; set; }

        public string? ImagePath { get; set; }



    }
}
