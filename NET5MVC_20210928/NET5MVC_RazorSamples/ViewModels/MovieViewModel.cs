using NET5MVC_RazorSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET5MVC_RazorSamples.ViewModels
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Artists> Cast { get; set; }

        public int ExterneIMDBRating { get; set; }
    }
}
