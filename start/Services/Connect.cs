using Microsoft.EntityFrameworkCore;
using start.Models;

namespace start.Services
{
    public partial class Connect : DbContext
    {
        public DbSet<Attendances> Attendances { get; set; }
        public DbSet<Coaches> Coaches { get; set; }
        public DbSet<Sportsmen> Sportsmens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = dabe.db");
        }
    }
}
