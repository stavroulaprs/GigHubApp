﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GigHubApplication.Models
{
    public class Gig
    {
        public int Id { get; set; }

        public bool IsCancelled { get; set; }

        [Required]
        public string ArtistId { get; set; }

        
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public byte GenreId { get; set; }

        
        public Genre Genre { get; set; }

    }
}