using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CanView.Models
{
    public class NowPlaying
    {
        public int NowPlayingID { get; set; }
        //public ICollection<Movie> movie { get; set; }
        public Screen screen { get; set; }
        //public ICollection<Warnings> warnings { get; set; }
        //public ICollection<Nights> nights { get; set; }

    }
}