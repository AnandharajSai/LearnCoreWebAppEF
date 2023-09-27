using LearnCoreWehAppEF.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnCoreWehAppEF.DBContext
{
    public class MoviewDBContext : DbContext
    {
        public MoviewDBContext() { }

        public MoviewDBContext(DbContextOptions<MoviewDBContext> options) : base(options) { }

        public DbSet<Movies>Movie { get; set; }
    }
}
