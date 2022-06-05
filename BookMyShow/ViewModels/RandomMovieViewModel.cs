using BookMyShow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMyShow.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }
    }
}