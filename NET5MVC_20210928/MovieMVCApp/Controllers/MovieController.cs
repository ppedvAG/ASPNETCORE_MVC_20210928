using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieMVCApp.Data;
using MovieMVCApp.Models;

namespace MovieMVCApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieDbContext _context;

        public MovieController(MovieDbContext context)
        {
            _context = context;
        }

        // GET: Movie
        public async Task<IActionResult> Index(string query)
        {
            //Hier darf ein Feature programmiert werden, dass mithilfe von ViewData realisiert 
            //Wir wollen den Suchbegriff in der Textbox angezeigt bekommen, wenn die Suchliste gefilter dargestellt wird

            IList<Movie> filteredList = string.IsNullOrEmpty(query) ? 
                await _context.Movie.ToListAsync() : 
                await _context.Movie.Where(q => q.Title.Contains(query) || q.Description.Contains(query)).ToListAsync();
           
            
            return View(filteredList);
        }

        // GET: Movie/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }


        public IActionResult Buy(int? id)
        {

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Buy1(int? id)
        {

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Wish(int? id)
        {

            return RedirectToAction(nameof(Index));
        }


        // GET: Movie/Create
        public IActionResult Create() //Sende das Formular(Html-Seite mit Formular) an den Browser
        {
            return View();
        }

        // POST: Movie/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598. //Benutzer füllt das Formular aus und klick den Button (submit) -> Der Browser sendet das Formular an den WebServer 
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("Id,Title,Description,GenreType,Price,IMDBRating")] Movie movie)
        {
            //Document 
            // Key / Value
            // Title | Star Wars
            // Description | Rückkehr der Jedi-Ritter


            //string myTilte = Request.Form["Title"];
            //string myDescription = Request.Form["Title"];

            //Movie movie = new Movie(myTitle, myDescription....)

            //Ich will eine Blackliste mit verwenden, die z.b den Film XYZ nicht hinzufügbar machen möchte
            if (movie.Title == "The Crow")
            {
                //AddModelError führt dazu, dass IsValid auf false gesetzt wird
                ModelState.AddModelError("Title", "Dieser Filmtitel steht auf dem Index");
            }

            //Serverseitig Valdierung ->
            if (ModelState.IsValid) //Ob alle DataAnnotations erfüllt wurden
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); //GET Methode -Index (Zeige mir die Tabelle mit allen Movies an) 
            }
            return View(movie);
        }

        public async Task<IActionResult> RandomCreate(Movie movie)
        {
            string[] movieNames = { "Star Wars", "Scary Movie", "Old School", "Die Erde", "Herr der Ringe" };
            
            Random rnd = new Random();
            if (string.IsNullOrEmpty(movie.Title))
            {
                movie.Title = movieNames[rnd.Next(0, 4)];
            }

            if (string.IsNullOrEmpty(movie.Description))
                movie.Description = "Film ist gut";


            if (movie.Price == 0)
                movie.Price = rnd.Next(5, 20);

            if (movie.GenreType == Genre.Default)
                movie.GenreType = Genre.Comedy;


            _context.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }














        // GET: Movie/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,GenreType,Price,IMDBRating")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movie/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
