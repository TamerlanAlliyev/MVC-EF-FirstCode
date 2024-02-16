using EfCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCodeFirst.Models.Contexts
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions option)
            : base(option)
        {

        }

        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
