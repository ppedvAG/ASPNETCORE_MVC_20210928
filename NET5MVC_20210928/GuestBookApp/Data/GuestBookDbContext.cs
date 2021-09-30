using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBookApp.Data
{
    public class GuestBookDbContext : DbContext
    {
        public GuestBookDbContext(DbContextOptions<GuestBookDbContext> options) //via options -> wird der ConnectionString geladen
            : base(options)
        {

        }

        //Tabelle werden mit DbSEt abgebildet
        public DbSet<GuestBookApp.Models.GuestBookEntry> GuestBook { get; set; }
    }
}
