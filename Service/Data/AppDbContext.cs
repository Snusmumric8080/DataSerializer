using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;

namespace Service.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Document> Documents { get; set; }
        public DbSet<Models.DocumentState> DocumentStates { get; set; }
    }
}
