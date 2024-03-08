using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bookstore.Data;

namespace Bookstore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Bookstore.Data.Author>? Author { get; set; }
        public DbSet<Bookstore.Data.Genre>? Genre { get; set; }
        public DbSet<Bookstore.Data.Book>? Book { get; set; }
    }
}