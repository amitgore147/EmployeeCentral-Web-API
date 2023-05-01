using FullStack.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Data
{
    public class FullStackDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public FullStackDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}