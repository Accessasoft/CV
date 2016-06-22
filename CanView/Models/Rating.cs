using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanView.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        public string RatingName { get; set; }
        public string RatingDesc { get; set; }
        //public virtual ICollection<Movie> movies { get; set; }
    }
}