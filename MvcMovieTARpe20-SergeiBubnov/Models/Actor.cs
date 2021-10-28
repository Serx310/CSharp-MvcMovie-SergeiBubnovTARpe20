using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovieTARpe20_SergeiBubnov.Models
{
    public class Actor
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        [Display(Name = "Place of birth")]
        public string PlaceOfBirth { get; set; }
        [Display(Name = "Born")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Born { get; set; }

        [Display(Name = "Beginning of Carrier")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BeginningOfCarrier { get; set; }


    }
}
