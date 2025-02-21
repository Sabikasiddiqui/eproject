using eproject.Models;
using Microsoft.EntityFrameworkCore;

namespace eproject.Context
{
    public class sqlcontext : DbContext
    {
        public sqlcontext(DbContextOptions<sqlcontext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; } 
    }
}
