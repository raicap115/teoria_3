using Microsoft.EntityFrameworkCore;
using teoria_3.Models;

namespace teoria_3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Home> Productos { get; set; }
        public ApplicationDbContext(DbContextOptions x) : base (x)
        {
            
        }
    }
}