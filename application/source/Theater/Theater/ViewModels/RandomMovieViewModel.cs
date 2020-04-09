using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Theater.Models;

namespace Theater.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}