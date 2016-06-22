
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CanView.Models
{
    public class Nights
    {
        public int NightsID { get; set; }
        public string NightName { get; set; }

        //public ICollection<NowPlaying> movieNights { get; set; }

    }
}