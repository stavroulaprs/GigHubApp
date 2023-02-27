using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GigHubApplication.Models
{
    public class Genre
    {
        public byte Id { get; set; }  //because there are only a few gernes
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}