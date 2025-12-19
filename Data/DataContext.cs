using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection;
using FitnessTracker.Models;

namespace FitnessTracker.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }


    // Add all DbSet<entity> entities { get; set;}
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Set> Sets { get; set; }
    public DbSet<Workout> Workouts { get; set; }
    
    //public DbSet<Program> Programs { get; set; }
    public DbSet<LoggedExercise> LoggedExercises { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); // Does nothing. Defensive practice


        // This finds every class in my project(assembly) that is using IEntityTypeConfiguration<TEntity>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}