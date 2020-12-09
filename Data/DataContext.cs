using Microsoft.EntityFrameworkCore;
using netCore3.Models;

namespace netCore3.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Character> Characters { get; set; }

        public DbSet<User> Users { get; set; }
    }
}