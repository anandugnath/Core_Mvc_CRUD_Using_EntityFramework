using core_mvc_CRUD_EF.Models;
using Microsoft.EntityFrameworkCore; 

namespace core_mvc_CRUD_EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Units> Units { get; set; } 
    }
}
