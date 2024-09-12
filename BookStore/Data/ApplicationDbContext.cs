using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BookStore.Data
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
