using EfCorePostgreDocker.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCorePostgreDocker.API.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
