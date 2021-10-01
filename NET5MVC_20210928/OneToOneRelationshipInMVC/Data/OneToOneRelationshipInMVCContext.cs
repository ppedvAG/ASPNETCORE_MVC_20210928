using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OneToOneRelationshipInMVC.Models;

namespace OneToOneRelationshipInMVC.Data
{
    public class OneToOneRelationshipInMVCContext : DbContext
    {
        public OneToOneRelationshipInMVCContext (DbContextOptions<OneToOneRelationshipInMVCContext> options)
            : base(options)
        {
        }

        public DbSet<OneToOneRelationshipInMVC.Models.Author> Author { get; set; }
    }
}
