using CrudcitoWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudcitoWeb.Databases;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
    }

    public DbSet<Coder> Coders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Coder>(tb => {
            tb.HasKey(col => col.Id);
            tb.Property(col => col.Id).UseMySqlIdentityColumn().ValueGeneratedOnAdd();
            tb.Property(col => col.Name).HasMaxLength(100);
            tb.Property(col => col.LastName).HasMaxLength(100);
            tb.Property(col => col.Email).HasMaxLength(100).IsRequired();
        });

        modelBuilder.Entity<Coder>().ToTable("Coder");
    }
}
