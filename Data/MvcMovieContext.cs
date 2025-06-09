using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data;

public class MvcMovieContext : DbContext
{
    public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.ToTable("Movies");
            entity.Property(e => e.Title).HasMaxLength(60).IsRequired();
            entity.Property(e => e.Genre).HasMaxLength(30).IsRequired();
            entity.Property(e => e.Rating).HasMaxLength(5).IsRequired();
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });
    }
} 