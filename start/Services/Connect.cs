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
            string dbPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\dabe.db"));
            optionsBuilder.UseSqlite($"Data source = {dbPath}");
        }
    }
}
