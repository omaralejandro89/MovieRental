﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Core.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int YearOfRelease { get; set; }
    }
}
