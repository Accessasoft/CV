
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanView.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public string MoviePlot { get; set; }
        public string MovieRunTime { get; set; }
        public string MoviePosetLoc { get; set; }
        public string MovieTrailerLoc { get; set; }
        public bool MovieIsNowPlaying { get; set; }
        public virtual Rating rating { get; set; }
        public virtual NowPlaying nowPlaying { get; set; }
    }
}