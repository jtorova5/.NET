using CrudcitoWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudcitoWeb.Databases;

public class AppDBContext : DbContext
{
    public DbSet<Coder> Coders { get; set; }

    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
    }
}
