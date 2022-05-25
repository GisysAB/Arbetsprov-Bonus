using Arbetsprov_Bonus.Entities;
using Microsoft.EntityFrameworkCore;

namespace Arbetsprov_Bonus.Data;

public class GisysDbContext : DbContext
{
    public GisysDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Starting consultants
        modelBuilder.Entity<Consultant>().HasKey(c => c.Id);

        modelBuilder.Entity<Consultant>().Property(c => c.Id).ValueGeneratedOnAdd();
    }

    public DbSet<Consultant> Consultants => Set<Consultant>();
}
