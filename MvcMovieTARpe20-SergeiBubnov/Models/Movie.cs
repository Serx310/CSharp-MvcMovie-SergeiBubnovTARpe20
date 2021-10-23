using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovieTARpe20_SergeiBubnov.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [MaxLength(128)]
        public string Title { get; set; }

        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        public  DateTime ReleaseDate { get; set; }
        [MaxLength(64)]
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [MaxLength(32)]
        public string Rating { get; set; }
    }
}
