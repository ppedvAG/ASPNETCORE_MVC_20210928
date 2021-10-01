using GuestBookApp.Data;
using GuestBookApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBookApp.Controllers
{
    public class GuestBookController : Controller
    {
        private readonly GuestBookDbContext _bookDbContext;

        public GuestBookController(GuestBookDbContext bookDbContext)
        {
            _bookDbContext = bookDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IList<GuestBookEntry> entries = await _bookDbContext.GuestBook.ToListAsync();
            return View(entries);
        }

        [HttpPost]
        public async Task<IActionResult> Index(GuestBookEntry newPost)
        {
            _bookDbContext.GuestBook.Add(newPost);
            await _bookDbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index)); //Rufen hier die Get-Methode Index auf -> Zeile 22
        }


        [HttpGet]
        public IActionResult Create() //Zeigt Formular an 
        {
            return View();
        }

        [HttpPost] 
        public async Task<IActionResult> Create(GuestBookEntry newPost) //Formular <form> -> wird von Browser an WebServer übertragen 
        {
            
            _bookDbContext.GuestBook.Add(newPost);
            await _bookDbContext.SaveChangesAsync(); //Hier wird der Datensatz (SQL) zur Datenbank übertragen und Datensatz wird in DB angelegt.
           
            return RedirectToAction(nameof(Index)); //Rufen hier die Get-Methode Index auf -> Zeile 22
        }
    }
}
