using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanView.Models
{
    class Genre
    {
        [Required]
        public int GenreID { get; set; }
        [Required]
        public string GenreName { get; set; }        
        public string GenreDescription { get; set; }
        //[Required]
        //public virtual ICollection<Movie> MoviesGenre { get; set; }

    }
}
