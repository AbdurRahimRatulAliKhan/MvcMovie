using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MoviegnereViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList gneres { get; set; }
        public string Moviegnere { get; set; }
        public string SearchString { get; set; }
    }
}