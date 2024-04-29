using Microsoft.EntityFrameworkCore;
using StudyAPI.Entities;

namespace StudyAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }
    }
}