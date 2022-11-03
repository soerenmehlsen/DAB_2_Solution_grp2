using DAB_2_Solution_grp2.Models;
using Microsoft.EntityFrameworkCore;

namespace DAB_2_Solution_grp2.Data;

public class MyDbContext : DbContext
{
    public DbSet<User>? Users { get; set; }
    public DbSet<Reservation>? Reservations { get; set; }
    public DbSet<Item>? Items { get; set; }
    public DbSet<Facility>? Facilities { get; set; }
    public DbSet<Company>? Companies { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(@"Data Source=localhost;Database=friluftslivaarhus_grp2;User ID=SA;Password=Nicolai123.;TrustServerCertificate=True");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) //Fluent API
    {

    }
}

