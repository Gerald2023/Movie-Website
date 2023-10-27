using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public double Cost { get; set; } 
        public int  RatingId { get; set; }

        public int FormatId { get; set; }

        public int DirectorId { get; set; }

        [DisplayName("Quantity")]

        public int InStkQty { get; set; }

        public string? ImagePath { get; set; }

        [DisplayName("Director")]
        public string? DirectorFullName { get; set; }
        public int Quantity { get; set; }
        public string Rating { get; set; }
        public string Format { get; set; }
    }
}
