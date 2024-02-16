using EfCodeFirst.Models.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EfCodeFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
             
            builder.Services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"));
            });

            var app = builder.Build();

            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
