﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryAPI.ViewModel
{
    public class MovieSummaryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Summary { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
    }
}
