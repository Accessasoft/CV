using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CanView.Models
{
    public class Warnings
    {
        public int WarningsID { get; set; }
        public string WarningsName { get; set; }
        public string WaringsDesc { get; set; }
        public DbSet<NowPlaying> movies { get; set; }
     }
}