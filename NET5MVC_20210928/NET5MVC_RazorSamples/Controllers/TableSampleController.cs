using Microsoft.AspNetCore.Mvc;
using NET5MVC_RazorSamples.Models;
using NET5MVC_RazorSamples.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET5MVC_RazorSamples.Controllers
{
    public class TableSampleController : Controller
    {
        public IActionResult Index()
        {
            IList<Movie> movies = new List<Movie>();

            movies.Add(new Movie
            {
                Id = 1,
                Title = "ES",
                Description = "Verwirrter Clown muss eigentlich zum Zahnarzt"
            });

            movies.Add(new Movie
            {
                Id = 1,
                Title = "Star Wars 10",
                Description = "Niederlage der JavaScript Entwickler"
            });

            movies.Add(new Movie
            {
                Id = 3,
                Title = "Star Wars 11",
                Description = ".NET Imperium schlägt zurück"
            });

            return View(movies);
        }


        public IActionResult ShowViewModelAsTable()
        {
            MovieViewModel vm = new MovieViewModel();

            vm.Movie = new Movie
            {
                Id = 1,
                Title = "Jurrasic Park",
                Description = "Handy klingelt auf Klo",
                Price = 19.99m
            };

            vm.Cast = new List<Artists>();
            vm.Cast.Add(new Artists
            {
                Id = 1,
                FirstName = "Otto",
                LastName = " Walkes"
            });

            vm.Cast.Add(new Artists
            {
                Id = 2,
                FirstName = "Harry",
                LastName = " Weinfuhrt"
            });

            vm.Cast.Add(new Artists
            {
                Id = 3,
                FirstName = "Ralf",
                LastName = " Möller"
            });

            vm.ExterneIMDBRating = 8;


            return View(vm);
        }
    }
}
