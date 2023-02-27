using GigHubApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigHubApplication.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }

        public bool ShowActions { get; set; } //when true-> I have buttons in index  when false->no buttons in index

        public string Heading { get; set; }
    }
}