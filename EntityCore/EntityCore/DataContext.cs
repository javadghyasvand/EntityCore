
using EntityCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityCore
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
