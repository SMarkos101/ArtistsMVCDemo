using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ArtistsMVCDemo.Models
{
    public class Artist
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(60, MinimumLength =3, ErrorMessage ="Should be between 3 and 60 characters long")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Should be between 3 and 60 characters long")]        
        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        { 
            get => $"{FirstName} {LastName}";
        }

        public ICollection<Album> Albums { get; set; }
    }
}