using ETSU.CampusTour.SharedLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class BucViewContext : DbContext
{
    public DbSet<College> College { get; set; }
    public DbSet<Department> Department { get; set; }
    public DbSet<PointsOfInterest> Points_Of_Interest { get; set; }
    public DbSet<Tour> Tours { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<TourBooking> Tour_Bookings { get; set; }
    public DbSet<Building> Buildings { get; set; }

    public BucViewContext(DbContextOptions<BucViewContext> options) : base(options)
    {
    }

}